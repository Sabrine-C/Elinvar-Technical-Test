Feature: Your test


Scenario: 1st case add a new asset

Given I have entered 'AsseTNamE12398654893' in <AssetName> field
When I press add
Then I should see the AsseTNamE12398654893 added :
            | AssetName| AsseTNamE12398654893|
           

Scenario:  2nd case the assetname should be unique 

Given I added 'AsseTNamE12398654893'
When I do add 'AsseTNamE12398654893' in <AssetName> field
And I do add
Then I see the following Message 'The asset name should be unique'



Scenario: 3rd case The asset name is a combination of 4 uppercase letters and 10 digitalis

Given I entered AssetName
When I submit 
Then The page displays 'Incorrect Format'

Scenario: 4rd case The asset name is a combination of 4 uppercase letters and 10 digitalis

Given I entered AsseTNamE65489312398 in <AssetName> field
When I submit 
Then The page displays the following :
           | assetname| AsseTNamE65489312398|
		   | assetname| AsseTNamE12398654893|
		   
		   
Scenario: 5rd case The ability to search by assert name

Given I entered 'AsseTNamE65489312398' in the search box
And 'AsseTNamE65489312398' is an existing Assetname
When I hit enter 
Then The page displays the following :
           | AssetName| AsseTNamE65489312398|
		   
		   
		   
Scenario: 6th case check the sort is available

Given The AssetTable page is open  
Then The page displays a sort button

Scenario: 7th case check the Filter is available

Given The AssetTable page is open  
Then The page displays a Filter button
		   
		   		   
		   
Scenario: 8th case The ability to sort  asset name

Given The AssetTable page is open  
When I sort by AssetName
Then The page displays the assetnames ordered alphabetically

		   
Scenario: 9th case The ability to filter by  asset name

Given The AssetTable page is open  
When I filter by AssetName
Then The page displays assetnames only
		   
		   
		   