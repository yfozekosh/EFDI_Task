/************************************
**  Query to get all campaigns of advertiser #100(Id 100) that have more than 50 ads. 
**  Author: Yurii Fozekosh
**  DateCreated: 12/08/2021
************************************/

SELECT C.Id, C.title
FROM [CAMPAIGN] C
WHERE C.AdvertiserId = 100
  AND (SELECT COUNT (1) FROM [AD] A WHERE A.CampaignId = C.Id)
    > 50


/************************************
**  Query to get all campaigns of advertiser #100(100th by Id) that have more than 50 ads. 
**  Author: Yurii Fozekosh
**  DateCreated: 12/08/2021
************************************/
WITH CampaignsNumbered(
    SELECT ROW_NUMBER() OVER (ORDER BY A.ID) RowNumber, A.* FROM [Advertiser] A
    )
FROM [CAMPAIGN] C
WHERE C.AdvertiserId = (SELECT RowNumber FROM [CampaignsNumbered] CN where CN.RowNumber = 100)
  AND (SELECT COUNT (1) FROM [AD] A WHERE A.CampaignId = C.Id)
    > 50