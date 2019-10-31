create table YL_AlterNotify
(
Id varchar(50) primary key,
BindId varchar(50),
OrderNum varchar(50),
Model varchar(50),
Alter_Date datetime,
Atler_Before varchar(2000),
Alter_After varchar(2000),
Yield_Stock decimal(18,3),
Semi_Stock decimal(18,3),
Raw_Stock decimal(18,3),
Supplier_Stock decimal(18,3),
Alter_Schedule varchar(100),
Dept varchar(50),
Alter_Cause varchar(200),
CreateDate datetime,
CreateUserId varchar(50),
CreateUserName varchar(50),
UpdateDate datetime,
UpdateUserId varchar(50),
UpdateUserName varchar(50)
)
--��ע��
execute sp_addextendedproperty 'MS_Description','���̨֪ͨ��','user','dbo','table','YL_AlterNotify',null,null;  
--�ֶ�ע��
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_AlterNotify','column','Id';
execute sp_addextendedproperty 'MS_Description','��Id','user','dbo','table','YL_AlterNotify','column','BindId';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_AlterNotify','column','OrderNum';
execute sp_addextendedproperty 'MS_Description','�ͺ�','user','dbo','table','YL_AlterNotify','column','Model';  
execute sp_addextendedproperty 'MS_Description','�������','user','dbo','table','YL_AlterNotify','column','Alter_Date';  
execute sp_addextendedproperty 'MS_Description','���ǰ����','user','dbo','table','YL_AlterNotify','column','Atler_Before';  
execute sp_addextendedproperty 'MS_Description','���������','user','dbo','table','YL_AlterNotify','column','Alter_After';  
execute sp_addextendedproperty 'MS_Description','��Ʒ���','user','dbo','table','YL_AlterNotify','column','Yield_Stock';  
execute sp_addextendedproperty 'MS_Description','���Ʒ���','user','dbo','table','YL_AlterNotify','column','Semi_Stock';  
execute sp_addextendedproperty 'MS_Description','ԭ���Ͽ��','user','dbo','table','YL_AlterNotify','column','Raw_Stock';  
execute sp_addextendedproperty 'MS_Description','��Ӧ�̿��','user','dbo','table','YL_AlterNotify','column','Supplier_Stock';  
execute sp_addextendedproperty 'MS_Description','�������','user','dbo','table','YL_AlterNotify','column','Alter_Schedule';  
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_AlterNotify','column','Dept';  
execute sp_addextendedproperty 'MS_Description','���ԭ��','user','dbo','table','YL_AlterNotify','column','Alter_Cause';
execute sp_addextendedproperty 'MS_Description','����ʱ��','user','dbo','table','YL_AlterNotify','column','CreateDate';  
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_AlterNotify','column','CreateUserName';  
execute sp_addextendedproperty 'MS_Description','����޸�ʱ��','user','dbo','table','YL_AlterNotify','column','UpdateDate';  
execute sp_addextendedproperty 'MS_Description','����޸���','user','dbo','table','YL_AlterNotify','column','UpdateUserName';  
create table YL_CustomerFeedBack
(
Id varchar(50) primary key,
BindId varchar(50),
OrderNum varchar(50),
Customer  varchar(50),
Feedback_Date datetime,
Model varchar(50),
SetNumber int,
ProduceDate datetime,
Feedback_Issue varchar(500),
EmergeAnalysis varchar(500),
OutflowAnalysis varchar(500),
Solution varchar(500),
VerifyResult varchar(500),
VerifyResult_Later varchar(500),
VerifyMan varchar(500),
CreateDate datetime,
CreateUserId varchar(50),
CreateUserName varchar(50),
UpdateDate datetime,
UpdateUserId varchar(50),
UpdateUserName varchar(50)
)
--��ע��
execute sp_addextendedproperty 'MS_Description','�ͻ�Ͷ��̨��','user','dbo','table','YL_CustomerFeedBack',null,null;  
--�ֶ�ע��
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_CustomerFeedBack','column','Id';
execute sp_addextendedproperty 'MS_Description','��Id','user','dbo','table','YL_CustomerFeedBack','column','BindId';
execute sp_addextendedproperty 'MS_Description','Ͷ�ߵ����','user','dbo','table','YL_CustomerFeedBack','column','OrderNum';
execute sp_addextendedproperty 'MS_Description','�ͻ�','user','dbo','table','YL_CustomerFeedBack','column','Customer';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_CustomerFeedBack','column','Feedback_Date';
execute sp_addextendedproperty 'MS_Description','�ͺ�','user','dbo','table','YL_CustomerFeedBack','column','Model';
execute sp_addextendedproperty 'MS_Description','̨��','user','dbo','table','YL_CustomerFeedBack','column','SetNumber';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_CustomerFeedBack','column','ProduceDate';
execute sp_addextendedproperty 'MS_Description','Ͷ������','user','dbo','table','YL_CustomerFeedBack','column','Feedback_Issue';
execute sp_addextendedproperty 'MS_Description','�����������','user','dbo','table','YL_CustomerFeedBack','column','EmergeAnalysis';
execute sp_addextendedproperty 'MS_Description','������������','user','dbo','table','YL_CustomerFeedBack','column','OutflowAnalysis';
execute sp_addextendedproperty 'MS_Description','�������','user','dbo','table','YL_CustomerFeedBack','column','Solution';
execute sp_addextendedproperty 'MS_Description','��֤���','user','dbo','table','YL_CustomerFeedBack','column','VerifyResult';
execute sp_addextendedproperty 'MS_Description','2���º���֤���','user','dbo','table','YL_CustomerFeedBack','column','VerifyResult_Later';
execute sp_addextendedproperty 'MS_Description','��֤��','user','dbo','table','YL_CustomerFeedBack','column','VerifyMan';
execute sp_addextendedproperty 'MS_Description','����ʱ��','user','dbo','table','YL_CustomerFeedBack','column','CreateDate';
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_CustomerFeedBack','column','CreateUserName';
execute sp_addextendedproperty 'MS_Description','����޸�ʱ��','user','dbo','table','YL_CustomerFeedBack','column','UpdateDate';
execute sp_addextendedproperty 'MS_Description','����޸���','user','dbo','table','YL_CustomerFeedBack','column','UpdateUserName';
create table YL_RefineSignUp
(
Id varchar(50) primary key,
BindId varchar(50),
OrderNum varchar(50),
CurrentSituation varchar(500),
Goal varchar(500),
Schedule_Start datetime,
Schedule_End datetime,
VerifyFulfill varchar(500),
DurationCondition varchar(500),
Dominant varchar(50),
Participation varchar(50),
CreateDate datetime,
CreateUserId varchar(50),
CreateUserName varchar(50),
UpdateDate datetime,
UpdateUserId varchar(50),
UpdateUserName varchar(50)
)
--��ע��
execute sp_addextendedproperty 'MS_Description','���ƵǼ�̨��','user','dbo','table','YL_RefineSignUp',null,null;  
--�ֶ�ע��
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_RefineSignUp','column','Id';
execute sp_addextendedproperty 'MS_Description','��Id','user','dbo','table','YL_RefineSignUp','column','BindId';
execute sp_addextendedproperty 'MS_Description','QC���Ʊ��','user','dbo','table','YL_RefineSignUp','column','OrderNum';
execute sp_addextendedproperty 'MS_Description','��״','user','dbo','table','YL_RefineSignUp','column','CurrentSituation';
execute sp_addextendedproperty 'MS_Description','���Ʒ�����Ŀ��','user','dbo','table','YL_RefineSignUp','column','Goal';
execute sp_addextendedproperty 'MS_Description','�ƻ�����ʱ��','user','dbo','table','YL_RefineSignUp','column','Schedule_Start';
execute sp_addextendedproperty 'MS_Description','�ƻ����ʱ��','user','dbo','table','YL_RefineSignUp','column','Schedule_End';
execute sp_addextendedproperty 'MS_Description','��֤������','user','dbo','table','YL_RefineSignUp','column','VerifyFulfill';
execute sp_addextendedproperty 'MS_Description','�������','user','dbo','table','YL_RefineSignUp','column','DurationCondition';
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_RefineSignUp','column','Dominant';
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_RefineSignUp','column','Participation';
execute sp_addextendedproperty 'MS_Description','����ʱ��','user','dbo','table','YL_RefineSignUp','column','CreateDate';
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_RefineSignUp','column','CreateUserName';
execute sp_addextendedproperty 'MS_Description','����޸���','user','dbo','table','YL_RefineSignUp','column','UpdateDate';
execute sp_addextendedproperty 'MS_Description','����޸�ʱ��','user','dbo','table','YL_RefineSignUp','column','UpdateUserName';
create table YL_DefectiveRepairSignUp
(
Id varchar(50) primary key,
BindId varchar(50),
OrderNum varchar(50),
RepairDate datetime,
Model varchar(50),
DefectiveExplain varchar(500),
DefectiveQuantity decimal(18,3),
DutySquad varchar(50),
RepairScheme varchar(500),
DutyMan varchar(50),
RepairStatus varchar(50),
Signature varchar(50),
Remark varchar(500),
CreateDate datetime,
CreateUserId varchar(50),
CreateUserName varchar(50),
UpdateDate datetime,
UpdateUserId varchar(50),
UpdateUserName varchar(50)
)
--��ע��
execute sp_addextendedproperty 'MS_Description','����Ʒ���޵Ǽ�̨��','user','dbo','table','YL_DefectiveRepairSignUp',null,null;  
--�ֶ�ע��
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_DefectiveRepairSignUp','column','Id';
execute sp_addextendedproperty 'MS_Description','��Id','user','dbo','table','YL_DefectiveRepairSignUp','column','BindId';
execute sp_addextendedproperty 'MS_Description','���޵���','user','dbo','table','YL_DefectiveRepairSignUp','column','OrderNum';
execute sp_addextendedproperty 'MS_Description','����ʱ��','user','dbo','table','YL_DefectiveRepairSignUp','column','RepairDate';
execute sp_addextendedproperty 'MS_Description','��Ʒ�ͺ�','user','dbo','table','YL_DefectiveRepairSignUp','column','Model';
execute sp_addextendedproperty 'MS_Description','��������˵��','user','dbo','table','YL_DefectiveRepairSignUp','column','DefectiveExplain';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_DefectiveRepairSignUp','column','DefectiveQuantity';
execute sp_addextendedproperty 'MS_Description','���ΰ���','user','dbo','table','YL_DefectiveRepairSignUp','column','DutySquad';
execute sp_addextendedproperty 'MS_Description','���޷���','user','dbo','table','YL_DefectiveRepairSignUp','column','RepairScheme';
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_DefectiveRepairSignUp','column','DutyMan';
execute sp_addextendedproperty 'MS_Description','����״̬','user','dbo','table','YL_DefectiveRepairSignUp','column','RepairStatus';
execute sp_addextendedproperty 'MS_Description','LQCǩ��','user','dbo','table','YL_DefectiveRepairSignUp','column','Signature';
execute sp_addextendedproperty 'MS_Description','��ע','user','dbo','table','YL_DefectiveRepairSignUp','column','Remark';
execute sp_addextendedproperty 'MS_Description','����ʱ��','user','dbo','table','YL_DefectiveRepairSignUp','column','CreateDate';
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_DefectiveRepairSignUp','column','CreateUserName';
execute sp_addextendedproperty 'MS_Description','������ʱ��','user','dbo','table','YL_DefectiveRepairSignUp','column','UpdateDate';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_DefectiveRepairSignUp','column','UpdateUserName';

create table YL_SpecialPurchase
(
Id varchar(50) primary key,
BindId varchar(50),
OrderNum varchar(50),
PurchaseDate datetime,
Model varchar(50),
Spec varchar(500),
Quantity decimal(18,3),
DefectiveExplain varchar(500),
UsageMethod varchar(500),
OnlineDate datetime,
Deliver varchar(50),
Supplier varchar(50),
Customer varchar(50),
CreateDate datetime,
CreateUserId varchar(50),
CreateUserName varchar(50),
UpdateDate datetime,
UpdateUserId varchar(50),
UpdateUserName varchar(50)
)
--��ע��
execute sp_addextendedproperty 'MS_Description','�زɵ��Ǽ�̨��','user','dbo','table','YL_SpecialPurchase',null,null;  
--�ֶ�ע��
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_DefectiveRepairSignUp','column','Id';
execute sp_addextendedproperty 'MS_Description','��Id','user','dbo','table','YL_DefectiveRepairSignUp','column','BindId';
execute sp_addextendedproperty 'MS_Description','�زɵ���','user','dbo','table','YL_DefectiveRepairSignUp','column','OrderNum';
execute sp_addextendedproperty 'MS_Description','�ز�����','user','dbo','table','YL_DefectiveRepairSignUp','column','PurchaseDate';
execute sp_addextendedproperty 'MS_Description','��Ʒ�ͺ�','user','dbo','table','YL_DefectiveRepairSignUp','column','Model';
execute sp_addextendedproperty 'MS_Description','���','user','dbo','table','YL_DefectiveRepairSignUp','column','Spec';
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_DefectiveRepairSignUp','column','Quantity';
execute sp_addextendedproperty 'MS_Description','ȱ��˵��','user','dbo','table','YL_DefectiveRepairSignUp','column','DefectiveExplain';
execute sp_addextendedproperty 'MS_Description','ʹ�÷���','user','dbo','table','YL_DefectiveRepairSignUp','column','UsageMethod';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_DefectiveRepairSignUp','column','OnlineDate';
execute sp_addextendedproperty 'MS_Description','��Ʒ����','user','dbo','table','YL_DefectiveRepairSignUp','column','Deliver';
execute sp_addextendedproperty 'MS_Description','��Ӧ��','user','dbo','table','YL_DefectiveRepairSignUp','column','Supplier';
execute sp_addextendedproperty 'MS_Description','�ͻ�','user','dbo','table','YL_DefectiveRepairSignUp','column','Customer';
execute sp_addextendedproperty 'MS_Description','����ʱ��','user','dbo','table','YL_DefectiveRepairSignUp','column','CreateDate';
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_DefectiveRepairSignUp','column','CreateUserName';
execute sp_addextendedproperty 'MS_Description','����޸�ʱ��','user','dbo','table','YL_DefectiveRepairSignUp','column','UpdateDate';
execute sp_addextendedproperty 'MS_Description','����޸���','user','dbo','table','YL_DefectiveRepairSignUp','column','UpdateUserName';
create table YL_EvaluationReport
(
Id varchar(50) primary key,
BindId varchar(50),
OrderNum varchar(50),
EvalDate datetime,
Customer varchar(50),
Quantity decimal(18,3),
EvalContent varchar(500),
IssueSpot varchar(500),
RefineContent varchar(500),
RefineNode varchar(50),
EvalResult varchar(500),
EMC varchar(50),
IsPass varchar(50),
Remark varchar(500),
CreateDate datetime,
CreateUserId varchar(50),
CreateUserName varchar(50),
UpdateDate datetime,
UpdateUserId varchar(50),
UpdateUserName varchar(50)
)
--��ע��
execute sp_addextendedproperty 'MS_Description','��������Ǽ�̨��','user','dbo','table','YL_EvaluationReport',null,null;  
--�ֶ�ע��
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_EvaluationReport','column','Id';
execute sp_addextendedproperty 'MS_Description','��Id','user','dbo','table','YL_EvaluationReport','column','BindId';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_EvaluationReport','column','OrderNum';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_EvaluationReport','column','EvalDate';
execute sp_addextendedproperty 'MS_Description','�ͻ�','user','dbo','table','YL_EvaluationReport','column','Customer';
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_EvaluationReport','column','Quantity';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_EvaluationReport','column','EvalContent';
execute sp_addextendedproperty 'MS_Description','�����','user','dbo','table','YL_EvaluationReport','column','IssueSpot';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_EvaluationReport','column','RefineContent';
execute sp_addextendedproperty 'MS_Description','ʱ��ڵ�','user','dbo','table','YL_EvaluationReport','column','RefineNode';
execute sp_addextendedproperty 'MS_Description','��֤���','user','dbo','table','YL_EvaluationReport','column','EvalResult';
execute sp_addextendedproperty 'MS_Description','EMC','user','dbo','table','YL_EvaluationReport','column','EMC';
execute sp_addextendedproperty 'MS_Description','�Ƿ�ͨ��','user','dbo','table','YL_EvaluationReport','column','IsPass';
execute sp_addextendedproperty 'MS_Description','��ע','user','dbo','table','YL_EvaluationReport','column','Remark';
execute sp_addextendedproperty 'MS_Description','����ʱ��','user','dbo','table','YL_EvaluationReport','column','CreateDate';
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_EvaluationReport','column','CreateUserName';
execute sp_addextendedproperty 'MS_Description','����޸�ʱ��','user','dbo','table','YL_EvaluationReport','column','UpdateDate';
execute sp_addextendedproperty 'MS_Description','����޸���','user','dbo','table','YL_EvaluationReport','column','UpdateUserName';
create table YL_IT_FirstConfirm
(
Id varchar(50) primary key,
BindId varchar(50),
OrderNum varchar(50),
Model varchar(50),
Customer varchar(50),
ConfirmDate datetime,
Project varchar(50),
Quality varchar(50),
ConfirmStandard_U varchar(50),
ActualMeasure_U varchar(50),
ConfirmDate_U datetime,
ConfirmStandard_V varchar(50),
ActualMeasure_V varchar(50),
ConfirmDate_V datetime,
ConfirmStandard_W varchar(50),
ActualMeasure_W varchar(50),
ConfirmDate_W datetime,
CreateDate datetime,
CreateUserId varchar(50),
CreateUserName varchar(50),
UpdateDate datetime,
UpdateUserId varchar(50),
UpdateUserName varchar(50)
)
--��ע��
execute sp_addextendedproperty 'MS_Description','IT�׼�ȷ�ϱ�','user','dbo','table','YL_IT_FirstConfirm',null,null;  
--�ֶ�ע��
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_IT_FirstConfirm','column','Id';
execute sp_addextendedproperty 'MS_Description','��Id','user','dbo','table','YL_IT_FirstConfirm','column','BindId';
execute sp_addextendedproperty 'MS_Description','ȷ�ϵ���','user','dbo','table','YL_IT_FirstConfirm','column','OrderNum';
execute sp_addextendedproperty 'MS_Description','�ͺ�','user','dbo','table','YL_IT_FirstConfirm','column','Model';
execute sp_addextendedproperty 'MS_Description','�ͻ�','user','dbo','table','YL_IT_FirstConfirm','column','Customer';
execute sp_addextendedproperty 'MS_Description','ȷ������','user','dbo','table','YL_IT_FirstConfirm','column','ConfirmDate';
execute sp_addextendedproperty 'MS_Description','��Ŀ','user','dbo','table','YL_IT_FirstConfirm','column','Project';
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_IT_FirstConfirm','column','Quality';
execute sp_addextendedproperty 'MS_Description','U��ȷ�ϱ�׼','user','dbo','table','YL_IT_FirstConfirm','column','ConfirmStandard_U';
execute sp_addextendedproperty 'MS_Description','U��ʵ��','user','dbo','table','YL_IT_FirstConfirm','column','ActualMeasure_U';
execute sp_addextendedproperty 'MS_Description','U��ȷ��ʱ��','user','dbo','table','YL_IT_FirstConfirm','column','ConfirmDate_U';
execute sp_addextendedproperty 'MS_Description','V��ȷ�ϱ�׼','user','dbo','table','YL_IT_FirstConfirm','column','ConfirmStandard_V';
execute sp_addextendedproperty 'MS_Description','V��ʵ��','user','dbo','table','YL_IT_FirstConfirm','column','ActualMeasure_V';
execute sp_addextendedproperty 'MS_Description','V��ȷ��ʱ��','user','dbo','table','YL_IT_FirstConfirm','column','ConfirmDate_V';
execute sp_addextendedproperty 'MS_Description','W��ȷ�ϱ�׼','user','dbo','table','YL_IT_FirstConfirm','column','ConfirmStandard_W';
execute sp_addextendedproperty 'MS_Description','W��ʵ��','user','dbo','table','YL_IT_FirstConfirm','column','ActualMeasure_W';
execute sp_addextendedproperty 'MS_Description','W��ȷ��ʱ��','user','dbo','table','YL_IT_FirstConfirm','column','ConfirmDate_W';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_IT_FirstConfirm','column','CreateDate';
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_IT_FirstConfirm','column','CreateUserName';
execute sp_addextendedproperty 'MS_Description','����޸���','user','dbo','table','YL_IT_FirstConfirm','column','UpdateDate';
execute sp_addextendedproperty 'MS_Description','����޸�ʱ��','user','dbo','table','YL_IT_FirstConfirm','column','UpdateUserName';
create table YL_CodeProcRecord
(
Id varchar(50) primary key,
BindId varchar(50),
OrderNum varchar(50),
RecordDate datetime,
RecordMan varchar(50),
Model varchar(50),
Spec varchar(50),
Material varchar(50),
OverlapStandard varchar(50),
OverlapMeasure varchar(50),
Gap varchar(50),
MidColHeightStandard varchar(50),
MidColHeightMeasure varchar(50),
UnionState varchar(50),
Judge varchar(50),
ConfirmSquad varchar(50),
ConfirmQuality varchar(50),
CreateDate datetime,
CreateUserId varchar(50),
CreateUserName varchar(50),
UpdateDate datetime,
UpdateUserId varchar(50),
UpdateUserName varchar(50)
)
--��ע��
execute sp_addextendedproperty 'MS_Description','���������¼��','user','dbo','table','YL_CodeProcRecord',null,null;  
--�ֶ�ע��
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_CodeProcRecord','column','Id';
execute sp_addextendedproperty 'MS_Description','��Id','user','dbo','table','YL_CodeProcRecord','column','BindId';
execute sp_addextendedproperty 'MS_Description','���򵥺�','user','dbo','table','YL_CodeProcRecord','column','OrderNum';
execute sp_addextendedproperty 'MS_Description','��¼ʱ��','user','dbo','table','YL_CodeProcRecord','column','RecordDate';
execute sp_addextendedproperty 'MS_Description','��¼��','user','dbo','table','YL_CodeProcRecord','column','RecordMan';
execute sp_addextendedproperty 'MS_Description','�ͺ�','user','dbo','table','YL_CodeProcRecord','column','Model';
execute sp_addextendedproperty 'MS_Description','���','user','dbo','table','YL_CodeProcRecord','column','Spec';
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_CodeProcRecord','column','Material';
execute sp_addextendedproperty 'MS_Description','�����׼','user','dbo','table','YL_CodeProcRecord','column','OverlapStandard';
execute sp_addextendedproperty 'MS_Description','����ʵ��','user','dbo','table','YL_CodeProcRecord','column','OverlapMeasure';
execute sp_addextendedproperty 'MS_Description','��϶','user','dbo','table','YL_CodeProcRecord','column','Gap';
execute sp_addextendedproperty 'MS_Description','�����߶ȱ�׼','user','dbo','table','YL_CodeProcRecord','column','MidColHeightStandard';
execute sp_addextendedproperty 'MS_Description','�����߶�ʵ��','user','dbo','table','YL_CodeProcRecord','column','MidColHeightMeasure';
execute sp_addextendedproperty 'MS_Description','���״̬','user','dbo','table','YL_CodeProcRecord','column','UnionState';
execute sp_addextendedproperty 'MS_Description','�ж�','user','dbo','table','YL_CodeProcRecord','column','Judge';
execute sp_addextendedproperty 'MS_Description','�೤ȷ��','user','dbo','table','YL_CodeProcRecord','column','ConfirmSquad';
execute sp_addextendedproperty 'MS_Description','Ʒ��ȷ��','user','dbo','table','YL_CodeProcRecord','column','ConfirmQuality';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_CodeProcRecord','column','CreateDate';
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_CodeProcRecord','column','CreateUserName';
execute sp_addextendedproperty 'MS_Description','����޸���','user','dbo','table','YL_CodeProcRecord','column','UpdateDate';
execute sp_addextendedproperty 'MS_Description','����޸�ʱ��','user','dbo','table','YL_CodeProcRecord','column','UpdateUserName';
create table YL_IT_InspectRoll
(
Id varchar(50) primary key,
BindId varchar(50),
OrderNum varchar(50),
RecordDate datetime,
RecordMan varchar(50),
InspectMan varchar(50),
IsQualify varchar(50),
DeviceCode varchar(50),
DeviceStatus varchar(50),
Model varchar(50),
MoldStatus varchar(50),
IsIntact varchar(50),
RollSizeStandard varchar(50),
RollSizeMeasure varchar(50),
CircleStandard varchar(50),
CircleMeasure varchar(50),
ThreadLenStandard varchar(50),
ThreadLenMeasure varchar(50),
TensionStandard varchar(50),
TensionMeasure varchar(50),
Conculsion varchar(500),
CreateDate datetime,
CreateUserId varchar(50),
CreateUserName varchar(50),
UpdateDate datetime,
UpdateUserId varchar(50),
UpdateUserName varchar(50)
)
--��ע��
execute sp_addextendedproperty 'MS_Description','ITС�;���Ѳ���¼','user','dbo','table','YL_IT_InspectRoll',null,null;  
--�ֶ�ע��
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_IT_InspectRoll','column','Id';
execute sp_addextendedproperty 'MS_Description','��Id','user','dbo','table','YL_IT_InspectRoll','column','BindId';
execute sp_addextendedproperty 'MS_Description','Ѳ�쵥��','user','dbo','table','YL_IT_InspectRoll','column','OrderNum';
execute sp_addextendedproperty 'MS_Description','��¼ʱ��','user','dbo','table','YL_IT_InspectRoll','column','RecordDate';
execute sp_addextendedproperty 'MS_Description','��¼��','user','dbo','table','YL_IT_InspectRoll','column','RecordMan';
execute sp_addextendedproperty 'MS_Description','Ѳ����','user','dbo','table','YL_IT_InspectRoll','column','InspectMan';
execute sp_addextendedproperty 'MS_Description','��Ա�����Ƿ�ϸ�','user','dbo','table','YL_IT_InspectRoll','column','IsQualify';
execute sp_addextendedproperty 'MS_Description','�豸���','user','dbo','table','YL_IT_InspectRoll','column','DeviceCode';
execute sp_addextendedproperty 'MS_Description','�豸״̬','user','dbo','table','YL_IT_InspectRoll','column','DeviceStatus';
execute sp_addextendedproperty 'MS_Description','��Ʒ�ͺ�','user','dbo','table','YL_IT_InspectRoll','column','Model';
execute sp_addextendedproperty 'MS_Description','ģ��״̬','user','dbo','table','YL_IT_InspectRoll','column','MoldStatus';
execute sp_addextendedproperty 'MS_Description','�ļ��Ƿ���ȫ','user','dbo','table','YL_IT_InspectRoll','column','IsIntact';
execute sp_addextendedproperty 'MS_Description','�߰��ߴ��׼','user','dbo','table','YL_IT_InspectRoll','column','RollSizeStandard';
execute sp_addextendedproperty 'MS_Description','�߱��ߴ�ʵ��','user','dbo','table','YL_IT_InspectRoll','column','RollSizeMeasure';
execute sp_addextendedproperty 'MS_Description','Ȧ��ȷ�ϱ�׼','user','dbo','table','YL_IT_InspectRoll','column','CircleStandard';
execute sp_addextendedproperty 'MS_Description','Ȧ��ȷ��ʵ��','user','dbo','table','YL_IT_InspectRoll','column','CircleMeasure';
execute sp_addextendedproperty 'MS_Description','���߳��ȱ�׼','user','dbo','table','YL_IT_InspectRoll','column','ThreadLenStandard';
execute sp_addextendedproperty 'MS_Description','���߳���ʵ��','user','dbo','table','YL_IT_InspectRoll','column','ThreadLenMeasure';
execute sp_addextendedproperty 'MS_Description','������׼','user','dbo','table','YL_IT_InspectRoll','column','TensionStandard';
execute sp_addextendedproperty 'MS_Description','����ʵ��','user','dbo','table','YL_IT_InspectRoll','column','TensionMeasure';
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_IT_InspectRoll','column','Conculsion';
execute sp_addextendedproperty 'MS_Description','��������','user','dbo','table','YL_IT_InspectRoll','column','CreateDate';
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_IT_InspectRoll','column','CreateUserName';
execute sp_addextendedproperty 'MS_Description','������޸���','user','dbo','table','YL_IT_InspectRoll','column','UpdateDate';
execute sp_addextendedproperty 'MS_Description','����޸�ʱ��','user','dbo','table','YL_IT_InspectRoll','column','UpdateUserName';

create table YL_IT_InspectOther
(
Id varchar(50) primary key,
BindId varchar(50),
OrderNum varchar(50),
RecordDate datetime,
RecordMan varchar(50),
InspectMan varchar(50),
Model varchar(50),
Content varchar(500),
Standard varchar(50),
CreateDate datetime,
CreateUserId varchar(50),
CreateUserName varchar(50),
UpdateDate datetime,
UpdateUserId varchar(50),
UpdateUserName varchar(50)
)
--��ע��
execute sp_addextendedproperty 'MS_Description','IT������Ѳ���¼','user','dbo','table','YL_IT_InspectOther',null,null;  
--�ֶ�ע��
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_IT_InspectOther','column','Id';
execute sp_addextendedproperty 'MS_Description','��Id','user','dbo','table','YL_IT_InspectOther','column','BindId';
execute sp_addextendedproperty 'MS_Description','Ѳ�쵥��','user','dbo','table','YL_IT_InspectOther','column','OrderNum';
execute sp_addextendedproperty 'MS_Description','��¼ʱ��','user','dbo','table','YL_IT_InspectOther','column','RecordDate';
execute sp_addextendedproperty 'MS_Description','��¼��','user','dbo','table','YL_IT_InspectOther','column','RecordMan';
execute sp_addextendedproperty 'MS_Description','Ѳ����','user','dbo','table','YL_IT_InspectOther','column','InspectMan';
execute sp_addextendedproperty 'MS_Description','��Ʒ�ͺ�','user','dbo','table','YL_IT_InspectOther','column','Model';
execute sp_addextendedproperty 'MS_Description','����','user','dbo','table','YL_IT_InspectOther','column','Content';
execute sp_addextendedproperty 'MS_Description','��׼','user','dbo','table','YL_IT_InspectOther','column','Standard';
execute sp_addextendedproperty 'MS_Description','����ʱ��','user','dbo','table','YL_IT_InspectOther','column','CreateDate';
execute sp_addextendedproperty 'MS_Description','������','user','dbo','table','YL_IT_InspectOther','column','CreateUserName';
execute sp_addextendedproperty 'MS_Description','����޸�ʱ��','user','dbo','table','YL_IT_InspectOther','column','UpdateDate';
execute sp_addextendedproperty 'MS_Description','����޸���','user','dbo','table','YL_IT_InspectOther','column','UpdateUserName';