if not exists(select * from sys.columns where object_id = object_id('queries') and name = 'PurposeOfUse')
	alter table queries add PurposeOfUse nvarchar(100)
go

if not exists(select * from sys.columns where object_id = object_id('queries') and name = 'PhiDisclosureLevel')
	alter table queries add PhiDisclosureLevel nvarchar(max)
go

IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[Requests]'))
	DROP VIEW [dbo].[Requests]
GO

CREATE VIEW [dbo].[Requests]
AS
SELECT     QueryId AS Id, CreatedByUserId, CreatedAt AS Created, RequestTypeId, QueryText AS QueryText_deprecated, Name, 
                      QueryDescription AS Description, RequestorEmail AS RequestorEmail_deprecated, IsDeleted, IsAdminQuery AS IsAdminQuery_deprecated, Priority, 
                      ActivityOfQuery AS ActivityOfQuery_deprecated, ActivityPriority AS ActivityPriority_deprecated, ActivityDescription, ActivityDueDate AS DueDate, 
                      IRBApprovalNo AS ApprovalCode, Submitted, updated, updatedbyuserid, ActivityId, IsTemplate, IsScheduled, [SID], OrganizationId,
					  PurposeOfUse, PhiDisclosureLevel
FROM         dbo.Queries

GO