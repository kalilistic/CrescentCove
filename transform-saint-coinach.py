#!/usr/bin/env python
import pandas as pd

# Extract File Names
class_job_file_name = "ClassJob"
world_file_name = "World"
item_file_name = "Item"
content_finder_condition_file_name = "ContentFinderCondition"
territory_type_file_name = "TerritoryType"
place_name_file_name = "PlaceName"
map_file_name = "Map"

# Extract Columns
class_job_cols = [
    'Key',
    'Name',
    'Abbreviation',
    'ClassJobCategory',
    'Name{English}',
    'Role']
world_cols = ['Key', 'Name']
item_cols = ['Key', 'Singular', 'Plural', 'Name']
content_finder_condition_cols = ['Key', 'TerritoryType', 'Name', 'HighEndDuty']
territory_type_cols = ['Key', 'PlaceName{Region}', 'PlaceName{Zone}', 'PlaceName', 'Map']
place_name_cols = ['Key', 'Name']
map_cols = ['Key', 'PlaceName{Sub}', 'TerritoryType']

# Other Variables
sep = "\x01"
src_dir = "./SaintCoinachExtracts/"
dest_dir = "./src/CrescentCove/Properties/"
property_ext = ".csv"


# Helper Functions
def remove_dummy_headers(file_src, file_dest):
    df = pd.read_csv(file_src, low_memory=False)
    df = df.drop([1, 1])
    df.to_csv(file_dest, sep=sep, header=False, index=False)


def rename_key_col(df):
    return df.rename(columns={"#": "Key"})


def read_csv(file_name):
    return pd.read_csv(file_name, sep=sep)


def remove_unused_cols(df, cols):
    return df[cols].replace(cols)


def write_transformed_csv(df, file_name):
    df.to_csv(file_name, sep=sep, header=False, index=False)


# Transform Functions
def transform_class_job():
    class_job_src = src_dir + class_job_file_name + property_ext
    class_job_dest = dest_dir + class_job_file_name + property_ext
    remove_dummy_headers(class_job_src, class_job_dest)
    df = read_csv(class_job_dest)
    df = rename_key_col(df)
    df = remove_unused_cols(df, class_job_cols)
    write_transformed_csv(df, class_job_dest)


def transform_world():
    world_src = src_dir + world_file_name + property_ext
    world_dest = dest_dir + world_file_name + property_ext
    remove_dummy_headers(world_src, world_dest)
    df = read_csv(world_dest)
    df = rename_key_col(df)
    df = df[df['IsPublic']]
    df = remove_unused_cols(df, world_cols)
    write_transformed_csv(df, world_dest)


def transform_item():
    item_src = src_dir + item_file_name + property_ext
    item_dest = dest_dir + item_file_name + property_ext
    remove_dummy_headers(item_src, item_dest)
    df = read_csv(item_dest)
    df = rename_key_col(df)

    # remove rows with empty cols
    df = df[df['Singular'] != '']
    df = df[df['Plural'] != '']
    df = df[df['Name'] != '']

    # remove dupes
    df = df.drop_duplicates(['Singular', 'Plural', 'Name'])

    # remove emphasis tags
    df = df.replace({'<Emphasis>': ''}, regex=True)
    df = df.replace({'</Emphasis>': ''}, regex=True)

    # drop bad record with id 0
    df = df.drop([0, 0])

    # remove unused columns
    df = remove_unused_cols(df, item_cols)

    # add isCommon column
    common_list = [
        'Gil',
        'MGP',
        'Wolf Mark',
        'Flame Seal',
        'Serpent Seal',
        'Storm Seal',
        'Allied Seal',
        'Fire Shard',
        'Ice Shard',
        'Wind Shard',
        'Earth Shard',
        'Lightning Shard',
        'Water Shard',
        'Fire Cluster',
        'Ice Cluster',
        'Wind Cluster',
        'Earth Cluster',
        'Lightning Cluster',
        'Water Cluster']
    common_list_pattern = [
        'Allagan Tomestone of',
        'Fire Crystal',
        'Ice Crystal',
        'Wind Crystal',
        'Earth Crystal',
        'Lightning Crystal',
        'Water Crystal']
    df = df.assign(isCommon=(df[df.columns[3]].str.contains(
        '|'.join(common_list_pattern))) | (df[df.columns[3]].isin(common_list)))

    # add isRetired items
    retired_list = [
        'Allagan Tomestone of Creation',
        'Allagan Tomestone of Verity',
        'Allagan Tomestone of Scripture',
        'Allagan Tomestone of Lore',
        'Allagan Tomestone of Esoterics',
        'Allagan Tomestone of Law',
        'Allagan Tomestone of Soldiery',
        'Allagan Tomestone of Mythology',
        'Allagan Tomestone of Philosophy']
    df = df.assign(isRetired=(df[df.columns[3]].isin(retired_list)))

    # write transformed csv
    write_transformed_csv(df, item_dest)


def transform_content_finder_condition():
    content_finder_condition_src = src_dir + content_finder_condition_file_name + property_ext
    content_finder_condition_dest = dest_dir + content_finder_condition_file_name + property_ext
    remove_dummy_headers(content_finder_condition_src, content_finder_condition_dest)
    df = read_csv(content_finder_condition_dest)
    df = rename_key_col(df)
    df['HighEndDuty'] = df['HighEndDuty'].astype(str)
    df = df[df['Name'] != '']
    df = df[df['Name'].notnull()]
    df = df.replace({'<Emphasis>': ''}, regex=True)
    df = df.replace({'</Emphasis>': ''}, regex=True)
    df = remove_unused_cols(df, content_finder_condition_cols)
    write_transformed_csv(df, content_finder_condition_dest)


def transform_territory_type():
    territory_type_src = src_dir + territory_type_file_name + property_ext
    territory_type_dest = dest_dir + territory_type_file_name + property_ext
    remove_dummy_headers(territory_type_src, territory_type_dest)
    df = read_csv(territory_type_dest)
    df = rename_key_col(df)
    df = remove_unused_cols(df, territory_type_cols)
    write_transformed_csv(df, territory_type_dest)


def transform_place_name():
    place_name_src = src_dir + place_name_file_name + property_ext
    place_name_dest = dest_dir + place_name_file_name + property_ext
    remove_dummy_headers(place_name_src, place_name_dest)
    df = read_csv(place_name_dest)
    df = rename_key_col(df)
    df = df[df['Name'] != '']
    df = df[df['Name'].notnull()]
    df = df[df['Name'] != '???']
    df = remove_unused_cols(df, place_name_cols)
    write_transformed_csv(df, place_name_dest)


def transform_map():
    map_src = src_dir + map_file_name + property_ext
    map_dest = dest_dir + map_file_name + property_ext
    remove_dummy_headers(map_src, map_dest)
    df = read_csv(map_dest)
    df = rename_key_col(df)
    df = remove_unused_cols(df, map_cols)
    write_transformed_csv(df, map_dest)


# Transform Extracts
transform_class_job()
transform_world()
transform_item()
transform_content_finder_condition()
transform_territory_type()
transform_place_name()
transform_map()
