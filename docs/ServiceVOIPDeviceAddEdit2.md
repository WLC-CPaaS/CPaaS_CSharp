# Org.OpenAPITools.Model.ServiceVOIPDeviceAddEdit2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallForward** | [**ModelsCallForward**](ModelsCallForward.md) |  | [optional] 
**CallerId** | [**ServiceVOIPDeviceAddEdit3c**](ServiceVOIPDeviceAddEdit3c.md) |  | [optional] 
**DeviceType** | **string** |  | [optional] 
**DoNotDisturb** | [**ModelsVOIPSharedDoNotDisturb**](ModelsVOIPSharedDoNotDisturb.md) |  | [optional] 
**Enabled** | **bool** | cannot use required, else it has to be true and false is not allowed | [optional] 
**MacAddress** | **string** | dont use mac, it enforces :, which voip does not like | [optional] 
**Media** | [**ServiceVOIPDeviceAddEdit3d**](ServiceVOIPDeviceAddEdit3d.md) |  | [optional] 
**MusicOnHold** | [**ModelsMusicOnHold**](ModelsMusicOnHold.md) |  | [optional] 
**Name** | **string** |  | 
**OwnerId** | **string** | json omitempty is needed else voip fails on \&quot;\&quot; for owner_id | [optional] 
**Provision** | [**ServiceVOIPDeviceAddEditProvision**](ServiceVOIPDeviceAddEditProvision.md) |  | [optional] 
**Sip** | [**ServiceVOIPDeviceAddEdit3a**](ServiceVOIPDeviceAddEdit3a.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

