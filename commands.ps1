#############################################################################
# 
# 
# - Resources
#   Install Azure PowerShell: https://docs.microsoft.com/en-us/powershell/azure/install-az-ps?view=azps-6.5.0
# 
#############################################################################

# install azure powershell
Install-Module -Name Az -Scope CurrentUser -Repository PSGallery -Force

# connect to azure
Connect-AzAccount

# create resource container
New-AzStorageAccount -ResourceGroupName neu-dallas-tech-night-rg `
    -Name acrdtndevcentralus001 `
    -Location centralus `
    -SkuName basic

# update image to container
New-AzStorageContainer
   [-Name] <String>
   [[-Permission] <BlobContainerPublicAccessType>]
   [-Context <IStorageContext>]
   [-ServerTimeoutPerRequest <Int32>]
   [-ClientTimeoutPerRequest <Int32>]
   [-DefaultProfile <IAzureContextContainer>]
   [-ConcurrentTaskCount <Int32>]
   [<CommonParameters>]