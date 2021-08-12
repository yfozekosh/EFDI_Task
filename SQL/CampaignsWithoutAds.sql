/************************************
**  Query to get all campaigns that do not have any ads.
**  Author: Yurii Fozekosh
**  DateCreated: 12/08/2021
************************************/

SELECT C.Id, C.title
FROM [CAMPAIGN] C
WHERE NOT EXISTS(SELECT 1 FROM [AD] A WHERE A.CampaignId = C.Id)