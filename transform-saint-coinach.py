#!/usr/bin/env python
import sys
import pandas as pd

### Configuration
classJobDest = "./CrescentCove/Properties/ClassJob.csv"
worldDest = "./CrescentCove/Properties/World.csv"
itemDest = "./CrescentCove/Properties/Item.csv"
contentFinderConditionDest = "./CrescentCove/Properties/ContentFinderCondition.csv"

classJobSrc = "./SaintCoinachExtracts/ClassJob.csv"
worldSrc = "./SaintCoinachExtracts/World.csv"
itemSrc = "./SaintCoinachExtracts/Item.csv"
contentFinderConditionSrc = "./SaintCoinachExtracts/ContentFinderCondition.csv"

classJobCols = ['Key','Name','Abbreviation','ClassJobCategory','Name{English}','Role']
worldCols = ['Key','Name']
itemCols = ['Key','Singular','Plural','Name']
contentFinderConditionCols = ['Key','TerritoryType','HighEndDuty']

sep = "\x01"

### Helper Functions
def removeDummyHeaders(fileSrc, fileDest):
	df = pd.read_csv(fileSrc, low_memory=False)
	df = df.drop([1,1])
	df.to_csv(fileDest, sep=sep, header=False, index=False)

def readCSV(fileName):
	return pd.read_csv(fileName, low_memory=False)
	
def renameKeyCol(df):
	return df.rename(columns={"#": "Key"})

def readCSV(fileName):
	return pd.read_csv(fileName, sep=sep)

def removeUnusedCols(df, cols):
	return df[cols].replace(cols)

def writeTransformedCSV(df, fileName):
	df.to_csv(fileName, sep=sep, header=False, index=False)

### Transform Functions
def transformClassJob():
	removeDummyHeaders(classJobSrc, classJobDest)
	df = readCSV(classJobDest)
	df = renameKeyCol(df)
	df = removeUnusedCols(df, classJobCols)
	writeTransformedCSV(df, classJobDest)

def transformWorld():
	removeDummyHeaders(worldSrc, worldDest)
	df = readCSV(worldDest)
	df = renameKeyCol(df)
	df = df[df['IsPublic'] == True]
	df = removeUnusedCols(df, worldCols)
	writeTransformedCSV(df, worldDest)

def transformItem():
	removeDummyHeaders(itemSrc, itemDest)
	df = readCSV(itemDest)
	df = renameKeyCol(df)
	
	# remove rows with empty cols
	df = df[df['Singular'] != '']
	df = df[df['Plural'] != '']
	df = df[df['Name'] != '']
	
	# remove dupes
	df = df.drop_duplicates(['Singular','Plural','Name'])
	
	# remove emphasis tags
	df = df.replace({'<Emphasis>': ''}, regex=True)
	df = df.replace({'</Emphasis>': ''}, regex=True)
	
	# drop bad record with id 0
	df = df.drop([0,0])
	
	# remove unused columns
	df = removeUnusedCols(df, itemCols)
	
	# add isCommon column
	commonList = ['Gil', 'MGP', 'Wolf Mark', 
		'Flame Seal', 'Serpent Seal', 'Storm Seal', 'Allied Seal', 
		'Fire Shard', 'Ice Shard', 'Wind Shard', 'Earth Shard', 'Lightning Shard', 'Water Shard',
		'Fire Cluster', 'Ice Cluster', 'Wind Cluster', 'Earth Cluster', 'Lightning Cluster', 'Water Cluster']
	commonListPattern = ['Allagan Tomestone of', 
		'Fire Crystal', 'Ice Crystal', 'Wind Crystal', 'Earth Crystal', 'Lightning Crystal', 'Water Crystal']	
	df = df.assign(isCommon=
	(df[df.columns[3]].str.contains('|'.join(commonListPattern))) |
	(df[df.columns[3]].isin(commonList)))

	# add isRetired items
	retiredList = ['Allagan Tomestone of Creation', 'Allagan Tomestone of Verity', 
		'Allagan Tomestone of Scripture', 'Allagan Tomestone of Lore', 'Allagan Tomestone of Esoterics', 
		'Allagan Tomestone of Law', 'Allagan Tomestone of Soldiery', 'Allagan Tomestone of Mythology', 
		'Allagan Tomestone of Philosophy']
	df = df.assign(isRetired=(df[df.columns[3]].isin(retiredList)))
	
	# write transformed csv
	writeTransformedCSV(df, itemDest)

def transformContentFinderCondition():
	removeDummyHeaders(contentFinderConditionSrc, contentFinderConditionDest)
	df = readCSV(contentFinderConditionDest)
	df = renameKeyCol(df)
	df['HighEndDuty']= df['HighEndDuty'].astype(str)
	df = removeUnusedCols(df, contentFinderConditionCols)
	writeTransformedCSV(df, contentFinderConditionDest)
	
	
### Transform Extracts
transformClassJob()
transformWorld()
transformItem()
transformContentFinderCondition()

