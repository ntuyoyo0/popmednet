-- This little snippet is "CLEANUP". To be used in case of the closure table coming out of sync with the original table (due to a bug).
-- It clears DAG closure table, then repopulates it from the original table, thus bringing it back into sync.



declare @t table( [Start] uniqueidentifier, [End] uniqueidentifier )


delete @t
insert into @t([Start], [End]) select [Start], [End] from SecurityMembership
delete SecurityMembership
delete SecurityMembershipClosure
insert into SecurityMembership([Start], [End]) select [Start], [End] from @t


delete @t
insert into @t([Start], [End]) select [Start], [End] from SecurityInheritance
delete SecurityInheritance
delete SecurityInheritanceClosure
insert into SecurityInheritance([Start], [End]) select [Start], [End] from @t

