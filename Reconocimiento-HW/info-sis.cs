using System.Management;
using System.Security.Cryptography.X509Certificates;
/*
  Las variables globales delaradas en este archivo son para que Nia sea conciente de 
  con que cuenta a mano y que no. Solo para que lo tome en cuenta.  
 */

/*
  Sacando todas las propiedades que WMI tiene del procesador me dio todo lo siguiente:
PSComputerName
Availability
CpuStatus
CurrentVoltage
DeviceID
ErrorCleared
ErrorDescription
LastErrorCode
LoadPercentage
Status
StatusInfo
AddressWidth
DataWidth
ExtClock
L2CacheSize
L2CacheSpeed
MaxClockSpeed
PowerManagementSupported
ProcessorType
Revision
SocketDesignation
Version
VoltageCaps
__GENUS
__CLASS
__SUPERCLASS
__DYNASTY
__RELPATH
__PROPERTY_COUNT
__DERIVATION
__SERVER
__NAMESPACE
__PATH
Architecture
AssetTag
Caption
Characteristics
ConfigManagerErrorCode
ConfigManagerUserConfig
CreationClassName
CurrentClockSpeed
Description
Family
InstallDate
L3CacheSize
L3CacheSpeed
Level
Manufacturer
Name
NumberOfCores
NumberOfEnabledCore
NumberOfLogicalProcessors
OtherFamilyDescription
PartNumber
PNPDeviceID
PowerManagementCapabilities
ProcessorId
Role
SecondLevelAddressTranslationExtensions
SerialNumber
Stepping
SystemCreationClassName
SystemName
ThreadCount
UniqueId
UpgradeMethod
VirtualizationFirmwareEnabled
VMMonitorModeExtensions
Scope
Path
Options
ClassPath
Properties
SystemProperties
Qualifiers
Site
Container

    Entonces hare una variable global por cada una por
 */
public class ReconocimientoHW
{
    public string
        //CPU
        cpu_Availability = "", cpu_CpuStatus = "", cpu_CurrentVoltage = "",
        cpu_DeviceID = "", cpu_ErrorCleared = "", cpu_ErrorDescription = "", cpu_LastErrorCode = "",
        cpu_LoadPercentage = "", cpu_Status = "", cpu_StatusInfo = "", cpu_AddressWidth = "",
        cpu_DataWidth = "", cpu_ExtClock = "", cpu_L2CacheSize = "", cpu_L2CacheSpeed = "",
        cpu_MaxClockSpeed = "", cpu_PowerManagementSupported = "", cpu_ProcessorType = "",
        cpu_Revision = "", cpu_SocketDesignation = "", cpu_Version = "", cpu_VoltageCaps = "",
        cpu___GENUS = "", cpu___CLASS = "", cpu___SUPERCLASS = "", cpu___DYNASTY = "",
        cpu___RELPATH = "", cpu___PROPERTY_COUNT = "", cpu___DERIVATION = "", cpu___SERVER = "",
        cpu___NAMESPACE = "", cpu___PATH = "", cpu_Architecture = "", cpu_AssetTag = "",
        cpu_Caption = "", cpu_Characteristics = "", cpu_ConfigManagerErrorCode = "",
        cpu_ConfigManagerUserConfig = "", cpu_CreationClassName = "", cpu_CurrentClockSpeed = "",
        cpu_Description = "", cpu_Family = "", cpu_InstallDate = "", cpu_L3CacheSize = "",
        cpu_L3CacheSpeed = "", cpu_Level = "", cpu_Manufacturer = "", cpu_Name = "",
        cpu_NumberOfCores = "", cpu_NumberOfEnabledCore = "", cpu_NumberOfLogicalProcessors = "",
        cpu_OtherFamilyDescription = "", cpu_PartNumber = "", cpu_PNPDeviceID = "",
        cpu_PowerManagementCapabilities = "", cpu_ProcessorId = "", cpu_Role = "",
        cpu_SecondLevelAddressTranslationExtensions = "", cpu_SerialNumber = "", cpu_Stepping = "",
        cpu_SystemCreationClassName = "", cpu_SystemName = "", cpu_ThreadCount = "",
        cpu_UniqueId = "", cpu_UpgradeMethod = "", cpu_VirtualizationFirmwareEnabled = "",
        cpu_VMMonitorModeExtensions = "",
        //RED
        net_AdapterType = "", net_AdapterTypeId = "", net_AutoSense = "", net_Availability = "",
        net_Caption = "", net_ConfigManagerErrorCode = "", net_ConfigManagerUserConfig = "",
        net_CreationClassName = "", net_Description = "", net_DeviceID = "", net_ErrorCleared = "",
        net_ErrorDescription = "", net_GUID = "", net_Index = "", net_InstallDate = "",
        net_Installed = "", net_InterfaceIndex = "", net_LastErrorCode = "", net_MACAddress = "",
        net_Manufacturer = "", net_MaxNumberControlled = "", net_MaxSpeed = "", net_Name = "",
        net_NetConnectionID = "", net_NetConnectionStatus = "", net_NetEnabled = "",
        net_NetworkAddresses = "", net_PermanentAddress = "", net_PhysicalAdapter = "",
        net_PNPDeviceID = "", net_PowerManagementCapabilities = "", net_PowerManagementSupported = "",
        net_ProductName = "", net_ServiceName = "", net_Speed = "", net_Status = "",
        net_StatusInfo = "", net_SystemCreationClassName = "", net_SystemName = "",
        net_TimeOfLastReset = "",
        net___GENUS = "", net___CLASS = "", net___SUPERCLASS = "", net___DYNASTY = "",
        net___RELPATH = "", net___PROPERTY_COUNT = "", net___DERIVATION = "", net___SERVER = "",
        net___NAMESPACE = "", net___PATH = "",
        //RAM
         ram_BankLabel = "", ram_Capacity = "", ram_DataWidth = "", ram_Description = "", ram_DeviceLocator = "",
         ram_FormFactor = "", ram_HotSwappable = "", ram_InstallDate = "", ram_InterleaveDataDepth = "",
         ram_InterleavePosition = "", ram_Manufacturer = "", ram_MemoryType = "", ram_Model = "", ram_Name = "",
         ram_OtherIdentifyingInfo = "", ram_PartNumber = "", ram_PositionInRow = "", ram_PoweredOn = "",
         ram_Removable = "", ram_Replaceable = "", ram_SerialNumber = "", ram_SKU = "", ram_SMBIOSMemoryType = "",
         ram_Speed = "", ram_Status = "", ram_Tag = "", ram_TotalWidth = "", ram_TypeDetail = "", ram_Version = "",
         ram_Caption = "", ram_CreationClassName = "", ram_ConfiguredClockSpeed = "", ram_ConfiguredVoltage = "",
         ram_MaxVoltage = "", ram_MinVoltage = "", ram_Attributes = "",
         ram___GENUS = "", ram___CLASS = "", ram___SUPERCLASS = "", ram___DYNASTY = "",
         ram___RELPATH = "", ram___PROPERTY_COUNT = "", ram___DERIVATION = "", ram___SERVER = "",
         ram___NAMESPACE = "", ram___PATH = "",
        //Discos
        dis_Availability = "", dis_BytesPerSector = "", dis_Capabilities = "", dis_CapabilityDescriptions = "",
        dis_Caption = "", dis_CompressionMethod = "", dis_ConfigManagerErrorCode = "", dis_ConfigManagerUserConfig = "",
        dis_CreationClassName = "", dis_DefaultBlockSize = "", dis_Description = "", dis_DeviceID = "",
        dis_ErrorCleared = "", dis_ErrorDescription = "", dis_ErrorMethodology = "", dis_FirmwareRevision = "",
        dis_Index = "", dis_InstallDate = "", dis_InterfaceType = "", dis_LastErrorCode = "",
        dis_Manufacturer = "", dis_MaxBlockSize = "", dis_MaxMediaSize = "", dis_MediaLoaded = "",
        dis_MediaType = "", dis_MinBlockSize = "", dis_Model = "", dis_Name = "",
        dis_NumberOfMediaSupported = "", dis_Partitions = "", dis_PNPDeviceID = "", dis_PowerManagementCapabilities = "",
        dis_PowerManagementSupported = "", dis_SCSIBus = "", dis_SCSILogicalUnit = "", dis_SCSIPort = "",
        dis_SCSITargetId = "", dis_SectorsPerTrack = "", dis_SerialNumber = "", dis_Signature = "",
        dis_Size = "", dis_Status = "", dis_StatusInfo = "", dis_SystemCreationClassName = "",
        dis_SystemName = "", dis_TotalCylinders = "", dis_TotalHeads = "", dis_TotalSectors = "",
        dis_TotalTracks = "", dis_TracksPerCylinder = "",
        dis___GENUS = "", dis___CLASS = "", dis___SUPERCLASS = "", dis___DYNASTY = "",
        dis___RELPATH = "", dis___PROPERTY_COUNT = "", dis___DERIVATION = "", dis___SERVER = "",
        dis___NAMESPACE = "", dis___PATH = "",
        //GPU
        gpu_AcceleratorCapabilities = "", gpu_AdapterCompatibility = "", gpu_AdapterDACType = "",
        gpu_AdapterRAM = "", gpu_Availability = "", gpu_CapabilityDescriptions = "", gpu_Caption = "",
        gpu_ColorTableEntries = "", gpu_ConfigManagerErrorCode = "", gpu_ConfigManagerUserConfig = "",
        gpu_CreationClassName = "", gpu_CurrentBitsPerPixel = "", gpu_CurrentHorizontalResolution = "",
        gpu_CurrentNumberOfColors = "", gpu_CurrentNumberOfColumns = "", gpu_CurrentNumberOfRows = "",
        gpu_CurrentRefreshRate = "", gpu_CurrentScanMode = "", gpu_CurrentVerticalResolution = "",
        gpu_Description = "", gpu_DeviceID = "", gpu_DeviceSpecificPens = "", gpu_DitherType = "",
        gpu_DriverDate = "", gpu_DriverVersion = "", gpu_ErrorCleared = "", gpu_ErrorDescription = "",
        gpu_ICMIntent = "", gpu_ICMMethod = "", gpu_InfFilename = "", gpu_InfSection = "",
        gpu_InstallDate = "", gpu_InstalledDisplayDrivers = "", gpu_LastErrorCode = "",
        gpu_MaxMemorySupported = "", gpu_MaxNumberControlled = "", gpu_MaxRefreshRate = "",
        gpu_MinRefreshRate = "", gpu_Monochrome = "", gpu_Name = "", gpu_NumberOfColorPlanes = "",
        gpu_NumberOfVideoPages = "", gpu_PNPDeviceID = "", gpu_PowerManagementCapabilities = "",
        gpu_PowerManagementSupported = "", gpu_ProtocolSupported = "", gpu_ReservedSystemPaletteEntries = "",
        gpu_SpecificationVersion = "", gpu_Status = "", gpu_StatusInfo = "", gpu_SystemCreationClassName = "",
        gpu_SystemName = "", gpu_SystemPaletteEntries = "", gpu_TimeOfLastReset = "",
        gpu_VideoArchitecture = "", gpu_VideoMemoryType = "", gpu_VideoMode = "",
        gpu_VideoModeDescription = "", gpu_VideoProcessor = "",
        gpu___GENUS = "", gpu___CLASS = "", gpu___SUPERCLASS = "", gpu___DYNASTY = "",
        gpu___RELPATH = "", gpu___PROPERTY_COUNT = "", gpu___DERIVATION = "", gpu___SERVER = "",
        gpu___NAMESPACE = "", gpu___PATH = "",
             // SISTEMA OPERATIVO
        so_BootDevice = "", so_BuildNumber = "", so_BuildType = "", so_Caption = "",
        so_CodeSet = "", so_CountryCode = "", so_CreationClassName = "", so_CSCreationClassName = "",
        so_CSDVersion = "", so_CSName = "", so_CurrentTimeZone = "", so_DataExecutionPrevention_32BitApplications = "",
        so_DataExecutionPrevention_Available = "", so_DataExecutionPrevention_Drivers = "",
        so_DataExecutionPrevention_SupportPolicy = "", so_Debug = "", so_Description = "",
        so_Distributed = "", so_EncryptionLevel = "", so_ForegroundApplicationBoost = "",
        so_FreePhysicalMemory = "", so_FreeSpaceInPagingFiles = "", so_FreeVirtualMemory = "",
        so_InstallDate = "", so_LargeSystemCache = "", so_LastBootUpTime = "", so_LocalDateTime = "",
        so_Locale = "", so_Manufacturer = "", so_MaxNumberOfProcesses = "", so_MaxProcessMemorySize = "",
        so_MUILanguages = "", so_Name = "", so_NumberOfLicensedUsers = "", so_NumberOfProcesses = "",
        so_NumberOfUsers = "", so_OperatingSystemSKU = "", so_Organization = "", so_OSArchitecture = "",
        so_OSLanguage = "", so_OSProductSuite = "", so_OSType = "", so_OtherTypeDescription = "",
        so_PAEEnabled = "", so_PlusProductID = "", so_PlusVersionNumber = "", so_PortableOperatingSystem = "",
        so_Primary = "", so_ProductType = "", so_RegisteredUser = "", so_SerialNumber = "",
        so_ServicePackMajorVersion = "", so_ServicePackMinorVersion = "", so_SizeStoredInPagingFiles = "",
        so_Status = "", so_SuiteMask = "", so_SystemDevice = "", so_SystemDirectory = "",
        so_SystemDrive = "", so_TotalSwapSpaceSize = "", so_TotalVirtualMemorySize = "",
        so_TotalVisibleMemorySize = "", so_Version = "", so_WindowsDirectory = "",
        so___GENUS = "", so___CLASS = "", so___SUPERCLASS = "", so___DYNASTY = "",
        so___RELPATH = "", so___PROPERTY_COUNT = "", so___DERIVATION = "", so___SERVER = "",
        so___NAMESPACE = "", so___PATH = "",
        //Bateria
        bat_Availability = "", bat_BatteryRechargeTime = "", bat_BatteryStatus = "",
        bat_Caption = "", bat_Chemistry = "", bat_ConfigManagerErrorCode = "",
        bat_ConfigManagerUserConfig = "", bat_CreationClassName = "", bat_Description = "",
        bat_DesignCapacity = "", bat_DesignVoltage = "", bat_DeviceID = "", bat_ErrorCleared = "",
        bat_ErrorDescription = "", bat_EstimatedChargeRemaining = "", bat_EstimatedRunTime = "",
        bat_ExpectedBatteryLife = "", bat_ExpectedLife = "", bat_FullChargeCapacity = "",
        bat_InstallDate = "", bat_LastErrorCode = "", bat_MaxRechargeTime = "", bat_Name = "",
        bat_PNPDeviceID = "", bat_PowerManagementCapabilities = "", bat_PowerManagementSupported = "",
        bat_SmartBatteryVersion = "", bat_Status = "", bat_StatusInfo = "",
        bat_SystemCreationClassName = "", bat_SystemName = "", bat_TimeOnBattery = "",
        bat_TimeToFullCharge = "",
        bat___GENUS = "", bat___CLASS = "", bat___SUPERCLASS = "", bat___DYNASTY = "",
        bat___RELPATH = "", bat___PROPERTY_COUNT = "", bat___DERIVATION = "", bat___SERVER = "",
        bat___NAMESPACE = "", bat___PATH = "";

    public void InfoSis()
    {

        var busqueda = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
        foreach (ManagementObject obj in busqueda.Get())
        {
            cpu_Availability = obj["Availability"]?.ToString()
                ?? "No disponible — No se pudo determinar el estado de disponibilidad operativa del procesador (ej. En uso, En espera, Apagado)";

            cpu_CpuStatus = obj["CpuStatus"]?.ToString()
                ?? "No disponible — No se pudo obtener el estado funcional actual del procesador (ej. Habilitado, Deshabilitado por BIOS)";

            cpu_CurrentVoltage = obj["CurrentVoltage"]?.ToString()
                ?? "No disponible — No se pudo leer el voltaje actual con el que opera el procesador en décimas de voltio";

            cpu_DeviceID = obj["DeviceID"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador único del dispositivo asignado al procesador por el sistema (ej. CPU0)";

            cpu_ErrorCleared = obj["ErrorCleared"]?.ToString()
                ?? "No disponible — No se pudo determinar si el último error registrado en el procesador fue limpiado o sigue activo";

            cpu_ErrorDescription = obj["ErrorDescription"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción del último error registrado por el procesador";

            cpu_LastErrorCode = obj["LastErrorCode"]?.ToString()
                ?? "No disponible — No se pudo recuperar el código numérico del último error reportado por el procesador";

            cpu_LoadPercentage = obj["LoadPercentage"]?.ToString()
                ?? "No disponible — No se pudo leer el porcentaje de uso actual del procesador en el momento de la consulta";

            cpu_Status = obj["Status"]?.ToString()
                ?? "No disponible — No se pudo obtener el estado general de operación del procesador (ej. OK, Error, Degradado)";

            cpu_StatusInfo = obj["StatusInfo"]?.ToString()
                ?? "No disponible — No se pudo obtener el código numérico que describe el estado de operación del procesador";

            cpu_AddressWidth = obj["AddressWidth"]?.ToString()
                ?? "No disponible — No se pudo determinar el ancho del espacio de direcciones del procesador en bits (32 o 64 bits)";

            cpu_DataWidth = obj["DataWidth"]?.ToString()
                ?? "No disponible — No se pudo determinar el ancho del bus de datos del procesador en bits (32 o 64 bits)";

            cpu_ExtClock = obj["ExtClock"]?.ToString()
                ?? "No disponible — No se pudo obtener la frecuencia del reloj externo del bus del procesador en MHz";

            cpu_L2CacheSize = obj["L2CacheSize"]?.ToString()
                ?? "No disponible — No se pudo leer el tamaño de la memoria caché de segundo nivel (L2) del procesador en KB";

            cpu_L2CacheSpeed = obj["L2CacheSpeed"]?.ToString()
                ?? "No disponible — No se pudo obtener la velocidad de operación de la caché L2 del procesador en MHz";

            cpu_MaxClockSpeed = obj["MaxClockSpeed"]?.ToString()
                ?? "No disponible — No se pudo leer la velocidad máxima de reloj del procesador en MHz";

            cpu_PowerManagementSupported = obj["PowerManagementSupported"]?.ToString()
                ?? "No disponible — No se pudo determinar si el procesador soporta funciones de administración de energía";

            cpu_ProcessorType = obj["ProcessorType"]?.ToString()
                ?? "No disponible — No se pudo identificar el tipo de procesador (ej. Central, Matemático, DSP, de Video)";

            cpu_Revision = obj["Revision"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de revisión del modelo del procesador reportado por el fabricante";

            cpu_SocketDesignation = obj["SocketDesignation"]?.ToString()
                ?? "No disponible — No se pudo identificar el tipo de socket de la placa madre donde está instalado el procesador (ej. LGA1700, AM5)";

            cpu_Version = obj["Version"]?.ToString()
                ?? "No disponible — No se pudo obtener la cadena de versión del procesador reportada por el fabricante";

            cpu_VoltageCaps = obj["VoltageCaps"]?.ToString()
                ?? "No disponible — No se pudieron obtener las capacidades de voltaje soportadas por el procesador";

            cpu___GENUS = obj["__GENUS"]?.ToString()
                ?? "No disponible — No se pudo leer el tipo de objeto WMI del procesador (indica si es instancia o definición de clase)";

            cpu___CLASS = obj["__CLASS"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI a la que pertenece este procesador";

            cpu___SUPERCLASS = obj["__SUPERCLASS"]?.ToString()
                ?? "No disponible — No se pudo determinar la clase padre WMI de la que hereda Win32_Processor";

            cpu___DYNASTY = obj["__DYNASTY"]?.ToString()
                ?? "No disponible — No se pudo obtener la clase raíz de la jerarquía WMI a la que pertenece este procesador";

            cpu___RELPATH = obj["__RELPATH"]?.ToString()
                ?? "No disponible — No se pudo obtener la ruta relativa WMI que identifica de forma única este procesador";

            cpu___PROPERTY_COUNT = obj["__PROPERTY_COUNT"]?.ToString()
                ?? "No disponible — No se pudo determinar el número total de propiedades WMI expuestas por este procesador";

            cpu___DERIVATION = obj["__DERIVATION"]?.ToString()
                ?? "No disponible — No se pudo obtener la cadena completa de herencia de clases WMI del procesador";

            cpu___SERVER = obj["__SERVER"]?.ToString()
                ?? "No disponible — No se pudo identificar el nombre del servidor WMI desde el que se obtuvo la información del procesador";

            cpu___NAMESPACE = obj["__NAMESPACE"]?.ToString()
                ?? "No disponible — No se pudo obtener el namespace WMI donde reside la clase Win32_Processor (ej. root\\cimv2)";

            cpu___PATH = obj["__PATH"]?.ToString()
                ?? "No disponible — No se pudo construir la ruta completa WMI que identifica de forma única este procesador en el sistema";

            cpu_Architecture = obj["Architecture"]?.ToString()
                ?? "No disponible — No se pudo determinar la arquitectura del procesador (ej. 0=x86, 9=x64, 12=ARM)";

            cpu_AssetTag = obj["AssetTag"]?.ToString()
                ?? "No disponible — No se pudo obtener la etiqueta de inventario del procesador asignada por el fabricante o administrador";

            cpu_Caption = obj["Caption"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción corta del procesador proporcionada por el sistema";

            cpu_Characteristics = obj["Characteristics"]?.ToString()
                ?? "No disponible — No se pudieron leer las características especiales del procesador (ej. soporte 64 bits, multicore)";

            cpu_ConfigManagerErrorCode = obj["ConfigManagerErrorCode"]?.ToString()
                ?? "No disponible — No se pudo obtener el código de error del Administrador de Configuración de Windows para el procesador";

            cpu_ConfigManagerUserConfig = obj["ConfigManagerUserConfig"]?.ToString()
                ?? "No disponible — No se pudo determinar si el procesador tiene una configuración personalizada en el Administrador de Configuración";

            cpu_CreationClassName = obj["CreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI utilizada para crear esta instancia del procesador";

            cpu_CurrentClockSpeed = obj["CurrentClockSpeed"]?.ToString()
                ?? "No disponible — No se pudo leer la velocidad de reloj actual real del procesador en MHz en el momento de la consulta";

            cpu_Description = obj["Description"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción detallada del procesador proporcionada por el sistema";

            cpu_Family = obj["Family"]?.ToString()
                ?? "No disponible — No se pudo identificar el código numérico de la familia a la que pertenece el procesador (ej. 198=Core i7)";

            cpu_InstallDate = obj["InstallDate"]?.ToString()
                ?? "No disponible — El sistema no registra una fecha de instalación para el procesador, este campo generalmente es nulo";

            cpu_L3CacheSize = obj["L3CacheSize"]?.ToString()
                ?? "No disponible — No se pudo leer el tamaño de la memoria caché de tercer nivel (L3) compartida del procesador en KB";

            cpu_L3CacheSpeed = obj["L3CacheSpeed"]?.ToString()
                ?? "No disponible — No se pudo obtener la velocidad de operación de la caché L3 del procesador en MHz";

            cpu_Level = obj["Level"]?.ToString()
                ?? "No disponible — No se pudo obtener el nivel de arquitectura del procesador definido por el fabricante";

            cpu_Manufacturer = obj["Manufacturer"]?.ToString()
                ?? "No disponible — No se pudo identificar el fabricante del procesador (ej. Intel, AMD)";

            cpu_Name = obj["Name"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre completo del procesador que incluye marca, modelo y frecuencia";

            cpu_NumberOfCores = obj["NumberOfCores"]?.ToString()
                ?? "No disponible — No se pudo determinar el número de núcleos físicos del procesador";

            cpu_NumberOfEnabledCore = obj["NumberOfEnabledCore"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de núcleos físicos actualmente habilitados en el procesador";

            cpu_NumberOfLogicalProcessors = obj["NumberOfLogicalProcessors"]?.ToString()
                ?? "No disponible — No se pudo determinar el número de procesadores lógicos (hilos) disponibles del procesador";

            cpu_OtherFamilyDescription = obj["OtherFamilyDescription"]?.ToString()
                ?? "No disponible — No hay descripción adicional de familia disponible, este campo solo aplica cuando Family=1 (Other)";

            cpu_PartNumber = obj["PartNumber"]?.ToString()
                ?? "No disponible — El número de parte del procesador no fue reportado por el fabricante";

            cpu_PNPDeviceID = obj["PNPDeviceID"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador Plug and Play asignado al procesador por Windows";

            cpu_PowerManagementCapabilities = obj["PowerManagementCapabilities"]?.ToString()
                ?? "No disponible — No se pudieron obtener las capacidades de administración de energía soportadas por el procesador";

            cpu_ProcessorId = obj["ProcessorId"]?.ToString()
                ?? "No disponible — No se pudo leer el identificador único del procesador grabado en el silicio por el fabricante";

            cpu_Role = obj["Role"]?.ToString()
                ?? "No disponible — No se pudo determinar el rol del procesador dentro del sistema (ej. Central Processor)";

            cpu_SecondLevelAddressTranslationExtensions = obj["SecondLevelAddressTranslationExtensions"]?.ToString()
                ?? "No disponible — No se pudo determinar si el procesador soporta extensiones SLAT necesarias para virtualización avanzada (Hyper-V)";

            cpu_SerialNumber = obj["SerialNumber"]?.ToString()
                ?? "No disponible — El número de serie del procesador no fue reportado, muchos fabricantes no exponen este dato por seguridad";

            cpu_Stepping = obj["Stepping"]?.ToString()
                ?? "No disponible — No se pudo obtener el stepping del procesador que indica la revisión específica del silicio fabricado";

            cpu_SystemCreationClassName = obj["SystemCreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI del sistema padre al que pertenece este procesador";

            cpu_SystemName = obj["SystemName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre del sistema operativo o equipo donde está instalado el procesador";

            cpu_ThreadCount = obj["ThreadCount"]?.ToString()
                ?? "No disponible — No se pudo determinar el número total de hilos de ejecución disponibles en el procesador";

            cpu_UniqueId = obj["UniqueId"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador global único del procesador, este campo generalmente está vacío por privacidad";

            cpu_UpgradeMethod = obj["UpgradeMethod"]?.ToString()
                ?? "No disponible — No se pudo determinar el método de actualización o tipo de socket soportado por el procesador";

            cpu_VirtualizationFirmwareEnabled = obj["VirtualizationFirmwareEnabled"]?.ToString()
                ?? "No disponible — No se pudo determinar si la virtualización por hardware está habilitada en el BIOS para este procesador";

            cpu_VMMonitorModeExtensions = obj["VMMonitorModeExtensions"]?.ToString()
                ?? "No disponible — No se pudo determinar si el procesador soporta extensiones de modo monitor de máquina virtual requeridas por Hyper-V";
        }
        busqueda = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
        foreach (ManagementObject obj in busqueda.Get())
        {
            ram_BankLabel = obj["BankLabel"]?.ToString()
                ?? "No disponible — El fabricante no reportó el banco físico donde está instalado el módulo de RAM";

            ram_Capacity = obj["Capacity"]?.ToString()
                ?? "No disponible — No se pudo obtener la capacidad en bytes del módulo de RAM";

            ram_DataWidth = obj["DataWidth"]?.ToString()
                ?? "No disponible — No se pudo determinar el ancho del bus de datos en bits del módulo de RAM";

            ram_Description = obj["Description"]?.ToString()
                ?? "No disponible — El sistema no proporcionó una descripción para este módulo de RAM";

            ram_DeviceLocator = obj["DeviceLocator"]?.ToString()
                ?? "No disponible — No se identificó la ranura física donde está instalado el módulo (ej. DIMM_A1)";

            ram_FormFactor = obj["FormFactor"]?.ToString()
                ?? "No disponible — No se pudo determinar el formato físico del módulo (ej. DIMM, SO-DIMM)";

            ram_HotSwappable = obj["HotSwappable"]?.ToString()
                ?? "No disponible — No se pudo determinar si el módulo de RAM soporta intercambio en caliente";

            ram_InstallDate = obj["InstallDate"]?.ToString()
                ?? "No disponible — El sistema no registra la fecha de instalación del módulo de RAM";

            ram_InterleaveDataDepth = obj["InterleaveDataDepth"]?.ToString()
                ?? "No disponible — No se pudo obtener la profundidad de interleaving de datos del módulo de RAM";

            ram_InterleavePosition = obj["InterleavePosition"]?.ToString()
                ?? "No disponible — No se pudo determinar la posición del módulo dentro del conjunto de interleaving";

            ram_Manufacturer = obj["Manufacturer"]?.ToString()
                ?? "No disponible — El fabricante del módulo de RAM no fue reportado por el sistema";

            ram_MemoryType = obj["MemoryType"]?.ToString()
                ?? "No disponible — No se pudo identificar el tipo de memoria (ej. DDR4, DDR5)";

            ram_Model = obj["Model"]?.ToString()
                ?? "No disponible — El modelo específico del módulo de RAM no fue reportado";

            ram_Name = obj["Name"]?.ToString()
                ?? "No disponible — El sistema no proporcionó un nombre para este módulo de RAM";

            ram_OtherIdentifyingInfo = obj["OtherIdentifyingInfo"]?.ToString()
                ?? "No disponible — No hay información adicional de identificación para este módulo de RAM";

            ram_PartNumber = obj["PartNumber"]?.ToString()
                ?? "No disponible — El número de parte del módulo de RAM no fue reportado por el fabricante";

            ram_PositionInRow = obj["PositionInRow"]?.ToString()
                ?? "No disponible — No se pudo determinar la posición del módulo dentro de su fila de memoria";

            ram_PoweredOn = obj["PoweredOn"]?.ToString()
                ?? "No disponible — No se pudo verificar si el módulo de RAM está actualmente energizado";

            ram_Removable = obj["Removable"]?.ToString()
                ?? "No disponible — No se pudo determinar si el módulo de RAM es extraíble físicamente";

            ram_Replaceable = obj["Replaceable"]?.ToString()
                ?? "No disponible — No se pudo determinar si el módulo de RAM es reemplazable";

            ram_SerialNumber = obj["SerialNumber"]?.ToString()
                ?? "No disponible — El número de serie del módulo de RAM no fue reportado por el fabricante";

            ram_SKU = obj["SKU"]?.ToString()
                ?? "No disponible — El código SKU del módulo de RAM no fue proporcionado por el fabricante";

            ram_SMBIOSMemoryType = obj["SMBIOSMemoryType"]?.ToString()
                ?? "No disponible — No se pudo leer el tipo de memoria según la tabla SMBIOS del sistema";

            ram_Speed = obj["Speed"]?.ToString()
                ?? "No disponible — No se pudo obtener la velocidad nominal del módulo de RAM en MHz";

            ram_Status = obj["Status"]?.ToString()
                ?? "No disponible — El sistema no reportó el estado operativo del módulo de RAM";

            ram_Tag = obj["Tag"]?.ToString()
                ?? "No disponible — No se encontró el identificador único WMI asignado a este módulo de RAM";

            ram_TotalWidth = obj["TotalWidth"]?.ToString()
                ?? "No disponible — No se pudo determinar el ancho total del bus incluyendo bits de paridad del módulo de RAM";

            ram_TypeDetail = obj["TypeDetail"]?.ToString()
                ?? "No disponible — No se pudo obtener el detalle adicional del tipo de memoria del módulo de RAM";

            ram_Version = obj["Version"]?.ToString()
                ?? "No disponible — La versión del módulo de RAM no fue reportada por el fabricante";

            ram_Caption = obj["Caption"]?.ToString()
                ?? "No disponible — El sistema no proporcionó una descripción corta para este módulo de RAM";

            ram_CreationClassName = obj["CreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI que representa este módulo de RAM";

            ram_ConfiguredClockSpeed = obj["ConfiguredClockSpeed"]?.ToString()
                ?? "No disponible — No se pudo leer la velocidad de reloj real configurada en el módulo de RAM en MHz";

            ram_ConfiguredVoltage = obj["ConfiguredVoltage"]?.ToString()
                ?? "No disponible — No se pudo obtener el voltaje real con el que opera actualmente el módulo de RAM";

            ram_MaxVoltage = obj["MaxVoltage"]?.ToString()
                ?? "No disponible — El fabricante no reportó el voltaje máximo soportado por este módulo de RAM";

            ram_MinVoltage = obj["MinVoltage"]?.ToString()
                ?? "No disponible — El fabricante no reportó el voltaje mínimo soportado por este módulo de RAM";

            ram_Attributes = obj["Attributes"]?.ToString()
                ?? "No disponible — No se pudieron leer los atributos adicionales de este módulo de RAM";



            ram___GENUS = obj["__GENUS"]?.ToString()
                ?? "No disponible — No se pudo leer el tipo de objeto WMI (instancia o clase) del módulo de RAM";

            ram___CLASS = obj["__CLASS"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI a la que pertenece este módulo de RAM";

            ram___SUPERCLASS = obj["__SUPERCLASS"]?.ToString()
                ?? "No disponible — No se pudo determinar la clase padre WMI de Win32_PhysicalMemory";

            ram___DYNASTY = obj["__DYNASTY"]?.ToString()
                ?? "No disponible — No se pudo obtener la clase raíz de la jerarquía WMI de este módulo de RAM";

            ram___RELPATH = obj["__RELPATH"]?.ToString()
                ?? "No disponible — No se pudo obtener la ruta relativa WMI que identifica este módulo de RAM";

            ram___PROPERTY_COUNT = obj["__PROPERTY_COUNT"]?.ToString()
                ?? "No disponible — No se pudo determinar el número total de propiedades WMI del módulo de RAM";

            ram___DERIVATION = obj["__DERIVATION"]?.ToString()
                ?? "No disponible — No se pudo obtener la cadena de herencia de clases WMI del módulo de RAM";

            ram___SERVER = obj["__SERVER"]?.ToString()
                ?? "No disponible — No se pudo identificar el servidor desde el que se obtuvo la información de RAM";

            ram___NAMESPACE = obj["__NAMESPACE"]?.ToString()
                ?? "No disponible — No se pudo obtener el namespace WMI donde reside la clase Win32_PhysicalMemory";

            ram___PATH = obj["__PATH"]?.ToString()
                ?? "No disponible — No se pudo construir la ruta completa WMI que identifica este módulo de RAM";
        }
        busqueda = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
        foreach (ManagementObject obj in busqueda.Get())
        {
            dis_Availability = obj["Availability"]?.ToString()
                ?? "No disponible — No se pudo determinar el estado de disponibilidad operativa de la unidad de almacenamiento (ej. En uso, En espera, Apagado)";

            dis_BytesPerSector = obj["BytesPerSector"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de bytes por sector físico de la unidad de almacenamiento";

            dis_Capabilities = obj["Capabilities"]?.ToString()
                ?? "No disponible — No se pudieron leer las capacidades soportadas por la unidad de almacenamiento (ej. acceso aleatorio, soporta escritura)";

            dis_CapabilityDescriptions = obj["CapabilityDescriptions"]?.ToString()
                ?? "No disponible — No se pudieron obtener las descripciones textuales de las capacidades de la unidad de almacenamiento";

            dis_Caption = obj["Caption"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción corta de la unidad de almacenamiento proporcionada por el sistema";

            dis_CompressionMethod = obj["CompressionMethod"]?.ToString()
                ?? "No disponible — No se pudo determinar el método de compresión utilizado por la unidad de almacenamiento";

            dis_ConfigManagerErrorCode = obj["ConfigManagerErrorCode"]?.ToString()
                ?? "No disponible — No se pudo obtener el código de error del Administrador de Configuración de Windows para la unidad de almacenamiento";

            dis_ConfigManagerUserConfig = obj["ConfigManagerUserConfig"]?.ToString()
                ?? "No disponible — No se pudo determinar si la unidad de almacenamiento tiene configuración personalizada en el Administrador de Configuración";

            dis_CreationClassName = obj["CreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI utilizada para crear esta instancia de la unidad de almacenamiento";

            dis_DefaultBlockSize = obj["DefaultBlockSize"]?.ToString()
                ?? "No disponible — No se pudo obtener el tamaño de bloque predeterminado en bytes de la unidad de almacenamiento";

            dis_Description = obj["Description"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción detallada de la unidad de almacenamiento proporcionada por el sistema";

            dis_DeviceID = obj["DeviceID"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador único del dispositivo asignado a la unidad de almacenamiento por el sistema (ej. \\\\.\\PHYSICALDRIVE0)";

            dis_ErrorCleared = obj["ErrorCleared"]?.ToString()
                ?? "No disponible — No se pudo determinar si el último error registrado en la unidad de almacenamiento fue limpiado o sigue activo";

            dis_ErrorDescription = obj["ErrorDescription"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción del último error registrado por la unidad de almacenamiento";

            dis_ErrorMethodology = obj["ErrorMethodology"]?.ToString()
                ?? "No disponible — No se pudo obtener el método de detección y corrección de errores utilizado por la unidad de almacenamiento";

            dis_FirmwareRevision = obj["FirmwareRevision"]?.ToString()
                ?? "No disponible — No se pudo obtener la versión del firmware instalado en la unidad de almacenamiento reportada por el fabricante";

            dis_Index = obj["Index"]?.ToString()
                ?? "No disponible — No se pudo obtener el índice numérico que identifica la posición de la unidad de almacenamiento en el sistema (ej. 0, 1, 2)";

            dis_InstallDate = obj["InstallDate"]?.ToString()
                ?? "No disponible — El sistema no registra una fecha de instalación para la unidad de almacenamiento, este campo generalmente es nulo";

            dis_InterfaceType = obj["InterfaceType"]?.ToString()
                ?? "No disponible — No se pudo identificar el tipo de interfaz de conexión de la unidad de almacenamiento (ej. SATA, NVMe, USB, SCSI)";

            dis_LastErrorCode = obj["LastErrorCode"]?.ToString()
                ?? "No disponible — No se pudo recuperar el código numérico del último error reportado por la unidad de almacenamiento";

            dis_Manufacturer = obj["Manufacturer"]?.ToString()
                ?? "No disponible — No se pudo identificar el fabricante de la unidad de almacenamiento (ej. Samsung, Seagate, Western Digital)";

            dis_MaxBlockSize = obj["MaxBlockSize"]?.ToString()
                ?? "No disponible — No se pudo obtener el tamaño máximo de bloque en bytes soportado por la unidad de almacenamiento";

            dis_MaxMediaSize = obj["MaxMediaSize"]?.ToString()
                ?? "No disponible — No se pudo obtener la capacidad máxima de medios soportada por la unidad de almacenamiento en KB";

            dis_MediaLoaded = obj["MediaLoaded"]?.ToString()
                ?? "No disponible — No se pudo determinar si el medio de almacenamiento está actualmente cargado y accesible en la unidad";

            dis_MediaType = obj["MediaType"]?.ToString()
                ?? "No disponible — No se pudo identificar el tipo de medio de la unidad de almacenamiento (ej. Fixed hard disk, Removable media)";

            dis_MinBlockSize = obj["MinBlockSize"]?.ToString()
                ?? "No disponible — No se pudo obtener el tamaño mínimo de bloque en bytes soportado por la unidad de almacenamiento";

            dis_Model = obj["Model"]?.ToString()
                ?? "No disponible — No se pudo obtener el modelo específico de la unidad de almacenamiento reportado por el fabricante";

            dis_Name = obj["Name"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre asignado a la unidad de almacenamiento por el sistema (ej. \\\\.\\PHYSICALDRIVE0)";

            dis_NumberOfMediaSupported = obj["NumberOfMediaSupported"]?.ToString()
                ?? "No disponible — No se pudo obtener el número máximo de medios que puede contener simultáneamente la unidad de almacenamiento";

            dis_Partitions = obj["Partitions"]?.ToString()
                ?? "No disponible — No se pudo obtener el número total de particiones creadas en la unidad de almacenamiento";

            dis_PNPDeviceID = obj["PNPDeviceID"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador Plug and Play asignado a la unidad de almacenamiento por Windows";

            dis_PowerManagementCapabilities = obj["PowerManagementCapabilities"]?.ToString()
                ?? "No disponible — No se pudieron obtener las capacidades de administración de energía soportadas por la unidad de almacenamiento";

            dis_PowerManagementSupported = obj["PowerManagementSupported"]?.ToString()
                ?? "No disponible — No se pudo determinar si la unidad de almacenamiento soporta funciones de administración de energía";

            dis_SCSIBus = obj["SCSIBus"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de bus SCSI al que está conectada la unidad de almacenamiento";

            dis_SCSILogicalUnit = obj["SCSILogicalUnit"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de unidad lógica SCSI asignado a la unidad de almacenamiento";

            dis_SCSIPort = obj["SCSIPort"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de puerto SCSI al que está conectada la unidad de almacenamiento";

            dis_SCSITargetId = obj["SCSITargetId"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador de destino SCSI de la unidad de almacenamiento";

            dis_SectorsPerTrack = obj["SectorsPerTrack"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de sectores por pista de la unidad de almacenamiento";

            dis_SerialNumber = obj["SerialNumber"]?.ToString()
                ?? "No disponible — El número de serie de la unidad de almacenamiento no fue reportado por el fabricante";

            dis_Signature = obj["Signature"]?.ToString()
                ?? "No disponible — No se pudo obtener la firma del disco que lo identifica de forma única en el sistema operativo";

            dis_Size = obj["Size"]?.ToString()
                ?? "No disponible — No se pudo obtener la capacidad total en bytes de la unidad de almacenamiento";

            dis_Status = obj["Status"]?.ToString()
                ?? "No disponible — No se pudo obtener el estado general de operación de la unidad de almacenamiento (ej. OK, Error, Degradado)";

            dis_StatusInfo = obj["StatusInfo"]?.ToString()
                ?? "No disponible — No se pudo obtener el código numérico que describe el estado de operación de la unidad de almacenamiento";

            dis_SystemCreationClassName = obj["SystemCreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI del sistema padre al que pertenece esta unidad de almacenamiento";

            dis_SystemName = obj["SystemName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre del equipo donde está instalada la unidad de almacenamiento";

            dis_TotalCylinders = obj["TotalCylinders"]?.ToString()
                ?? "No disponible — No se pudo obtener el número total de cilindros de la unidad de almacenamiento (geometría del disco)";

            dis_TotalHeads = obj["TotalHeads"]?.ToString()
                ?? "No disponible — No se pudo obtener el número total de cabezas de lectura de la unidad de almacenamiento (geometría del disco)";

            dis_TotalSectors = obj["TotalSectors"]?.ToString()
                ?? "No disponible — No se pudo obtener el número total de sectores de la unidad de almacenamiento";

            dis_TotalTracks = obj["TotalTracks"]?.ToString()
                ?? "No disponible — No se pudo obtener el número total de pistas de la unidad de almacenamiento (geometría del disco)";

            dis_TracksPerCylinder = obj["TracksPerCylinder"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de pistas por cilindro de la unidad de almacenamiento (geometría del disco)";

            dis___GENUS = obj["__GENUS"]?.ToString()
                ?? "No disponible — No se pudo leer el tipo de objeto WMI de la unidad de almacenamiento (indica si es instancia o definición de clase)";

            dis___CLASS = obj["__CLASS"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI a la que pertenece esta unidad de almacenamiento";

            dis___SUPERCLASS = obj["__SUPERCLASS"]?.ToString()
                ?? "No disponible — No se pudo determinar la clase padre WMI de la que hereda Win32_DiskDrive";

            dis___DYNASTY = obj["__DYNASTY"]?.ToString()
                ?? "No disponible — No se pudo obtener la clase raíz de la jerarquía WMI a la que pertenece esta unidad de almacenamiento";

            dis___RELPATH = obj["__RELPATH"]?.ToString()
                ?? "No disponible — No se pudo obtener la ruta relativa WMI que identifica de forma única esta unidad de almacenamiento";

            dis___PROPERTY_COUNT = obj["__PROPERTY_COUNT"]?.ToString()
                ?? "No disponible — No se pudo determinar el número total de propiedades WMI expuestas por esta unidad de almacenamiento";

            dis___DERIVATION = obj["__DERIVATION"]?.ToString()
                ?? "No disponible — No se pudo obtener la cadena completa de herencia de clases WMI de la unidad de almacenamiento";

            dis___SERVER = obj["__SERVER"]?.ToString()
                ?? "No disponible — No se pudo identificar el nombre del servidor WMI desde el que se obtuvo la información de la unidad de almacenamiento";

            dis___NAMESPACE = obj["__NAMESPACE"]?.ToString()
                ?? "No disponible — No se pudo obtener el namespace WMI donde reside la clase Win32_DiskDrive (ej. root\\cimv2)";

            dis___PATH = obj["__PATH"]?.ToString()
                ?? "No disponible — No se pudo construir la ruta completa WMI que identifica de forma única esta unidad de almacenamiento en el sistema";
        }
        busqueda = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
        foreach (ManagementObject obj in busqueda.Get())
        {
            gpu_AcceleratorCapabilities = obj["AcceleratorCapabilities"]?.ToString()
                ?? "No disponible — No se pudieron obtener las capacidades del acelerador gráfico (ej. soporte DirectX, OpenGL)";

            gpu_AdapterCompatibility = obj["AdapterCompatibility"]?.ToString()
                ?? "No disponible — No se pudo determinar la compatibilidad del adaptador gráfico con otros dispositivos o estándares";

            gpu_AdapterDACType = obj["AdapterDACType"]?.ToString()
                ?? "No disponible — No se pudo identificar el tipo de convertidor digital-analógico (DAC) del adaptador gráfico";

            gpu_AdapterRAM = obj["AdapterRAM"]?.ToString()
                ?? "No disponible — No se pudo obtener la cantidad de memoria RAM dedicada del adaptador gráfico en bytes";

            gpu_Availability = obj["Availability"]?.ToString()
                ?? "No disponible — No se pudo determinar el estado de disponibilidad operativa del adaptador gráfico (ej. En uso, En espera, Apagado)";

            gpu_CapabilityDescriptions = obj["CapabilityDescriptions"]?.ToString()
                ?? "No disponible — No se pudieron obtener las descripciones textuales de las capacidades del adaptador gráfico";

            gpu_Caption = obj["Caption"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción corta del adaptador gráfico proporcionada por el sistema";

            gpu_ColorTableEntries = obj["ColorTableEntries"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de entradas en la tabla de colores soportada por el adaptador gráfico";

            gpu_ConfigManagerErrorCode = obj["ConfigManagerErrorCode"]?.ToString()
                ?? "No disponible — No se pudo obtener el código de error del Administrador de Configuración de Windows para el adaptador gráfico";

            gpu_ConfigManagerUserConfig = obj["ConfigManagerUserConfig"]?.ToString()
                ?? "No disponible — No se pudo determinar si el adaptador gráfico tiene configuración personalizada en el Administrador de Configuración";

            gpu_CreationClassName = obj["CreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI utilizada para crear esta instancia del adaptador gráfico";

            gpu_CurrentBitsPerPixel = obj["CurrentBitsPerPixel"]?.ToString()
                ?? "No disponible — No se pudo obtener la profundidad de color actual en bits por píxel del adaptador gráfico (ej. 16, 24, 32)";

            gpu_CurrentHorizontalResolution = obj["CurrentHorizontalResolution"]?.ToString()
                ?? "No disponible — No se pudo obtener la resolución horizontal actual en píxeles del adaptador gráfico";

            gpu_CurrentNumberOfColors = obj["CurrentNumberOfColors"]?.ToString()
                ?? "No disponible — No se pudo obtener el número total de colores que puede mostrar actualmente el adaptador gráfico";

            gpu_CurrentNumberOfColumns = obj["CurrentNumberOfColumns"]?.ToString()
                ?? "No disponible — No se pudo obtener el número actual de columnas de caracteres en modo texto del adaptador gráfico";

            gpu_CurrentNumberOfRows = obj["CurrentNumberOfRows"]?.ToString()
                ?? "No disponible — No se pudo obtener el número actual de filas de caracteres en modo texto del adaptador gráfico";

            gpu_CurrentRefreshRate = obj["CurrentRefreshRate"]?.ToString()
                ?? "No disponible — No se pudo obtener la tasa de refresco actual del adaptador gráfico en Hz";

            gpu_CurrentScanMode = obj["CurrentScanMode"]?.ToString()
                ?? "No disponible — No se pudo determinar el modo de escaneo actual del adaptador gráfico (ej. progresivo o entrelazado)";

            gpu_CurrentVerticalResolution = obj["CurrentVerticalResolution"]?.ToString()
                ?? "No disponible — No se pudo obtener la resolución vertical actual en píxeles del adaptador gráfico";

            gpu_Description = obj["Description"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción detallada del adaptador gráfico proporcionada por el sistema";

            gpu_DeviceID = obj["DeviceID"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador único del dispositivo asignado al adaptador gráfico por el sistema";

            gpu_DeviceSpecificPens = obj["DeviceSpecificPens"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de plumas específicas del dispositivo soportadas por el adaptador gráfico";

            gpu_DitherType = obj["DitherType"]?.ToString()
                ?? "No disponible — No se pudo determinar el tipo de tramado utilizado por el adaptador gráfico para simular colores";

            gpu_DriverDate = obj["DriverDate"]?.ToString()
                ?? "No disponible — No se pudo obtener la fecha de lanzamiento del controlador instalado actualmente en el adaptador gráfico";

            gpu_DriverVersion = obj["DriverVersion"]?.ToString()
                ?? "No disponible — No se pudo obtener la versión del controlador instalado actualmente en el adaptador gráfico";

            gpu_ErrorCleared = obj["ErrorCleared"]?.ToString()
                ?? "No disponible — No se pudo determinar si el último error registrado en el adaptador gráfico fue limpiado o sigue activo";

            gpu_ErrorDescription = obj["ErrorDescription"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción del último error registrado por el adaptador gráfico";

            gpu_ICMIntent = obj["ICMIntent"]?.ToString()
                ?? "No disponible — No se pudo determinar la intención de gestión de color ICM del adaptador gráfico (ej. saturación, contraste)";

            gpu_ICMMethod = obj["ICMMethod"]?.ToString()
                ?? "No disponible — No se pudo obtener el método de gestión de color ICM utilizado por el adaptador gráfico";

            gpu_InfFilename = obj["InfFilename"]?.ToString()
                ?? "No disponible — No se pudo obtener la ruta del archivo INF del controlador instalado en el adaptador gráfico";

            gpu_InfSection = obj["InfSection"]?.ToString()
                ?? "No disponible — No se pudo obtener la sección del archivo INF utilizada para instalar el controlador del adaptador gráfico";

            gpu_InstallDate = obj["InstallDate"]?.ToString()
                ?? "No disponible — El sistema no registra una fecha de instalación para el adaptador gráfico, este campo generalmente es nulo";

            gpu_InstalledDisplayDrivers = obj["InstalledDisplayDrivers"]?.ToString()
                ?? "No disponible — No se pudo obtener la lista de controladores de pantalla instalados para el adaptador gráfico";

            gpu_LastErrorCode = obj["LastErrorCode"]?.ToString()
                ?? "No disponible — No se pudo recuperar el código numérico del último error reportado por el adaptador gráfico";

            gpu_MaxMemorySupported = obj["MaxMemorySupported"]?.ToString()
                ?? "No disponible — No se pudo obtener la cantidad máxima de memoria en bytes que soporta el adaptador gráfico";

            gpu_MaxNumberControlled = obj["MaxNumberControlled"]?.ToString()
                ?? "No disponible — No se pudo obtener el número máximo de dispositivos controlados directamente por el adaptador gráfico";

            gpu_MaxRefreshRate = obj["MaxRefreshRate"]?.ToString()
                ?? "No disponible — No se pudo obtener la tasa de refresco máxima soportada por el adaptador gráfico en Hz";

            gpu_MinRefreshRate = obj["MinRefreshRate"]?.ToString()
                ?? "No disponible — No se pudo obtener la tasa de refresco mínima soportada por el adaptador gráfico en Hz";

            gpu_Monochrome = obj["Monochrome"]?.ToString()
                ?? "No disponible — No se pudo determinar si el adaptador gráfico opera en modo monocromático";

            gpu_Name = obj["Name"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre completo del adaptador gráfico reportado por el fabricante";

            gpu_NumberOfColorPlanes = obj["NumberOfColorPlanes"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de planos de color soportados por el adaptador gráfico";

            gpu_NumberOfVideoPages = obj["NumberOfVideoPages"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de páginas de video disponibles en la memoria del adaptador gráfico";

            gpu_PNPDeviceID = obj["PNPDeviceID"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador Plug and Play asignado al adaptador gráfico por Windows";

            gpu_PowerManagementCapabilities = obj["PowerManagementCapabilities"]?.ToString()
                ?? "No disponible — No se pudieron obtener las capacidades de administración de energía soportadas por el adaptador gráfico";

            gpu_PowerManagementSupported = obj["PowerManagementSupported"]?.ToString()
                ?? "No disponible — No se pudo determinar si el adaptador gráfico soporta funciones de administración de energía";

            gpu_ProtocolSupported = obj["ProtocolSupported"]?.ToString()
                ?? "No disponible — No se pudo obtener el protocolo de comunicación soportado por el adaptador gráfico con el sistema";

            gpu_ReservedSystemPaletteEntries = obj["ReservedSystemPaletteEntries"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de entradas de paleta del sistema reservadas por el adaptador gráfico";

            gpu_SpecificationVersion = obj["SpecificationVersion"]?.ToString()
                ?? "No disponible — No se pudo obtener la versión de la especificación del estándar soportada por el adaptador gráfico";

            gpu_Status = obj["Status"]?.ToString()
                ?? "No disponible — No se pudo obtener el estado general de operación del adaptador gráfico (ej. OK, Error, Degradado)";

            gpu_StatusInfo = obj["StatusInfo"]?.ToString()
                ?? "No disponible — No se pudo obtener el código numérico que describe el estado de operación del adaptador gráfico";

            gpu_SystemCreationClassName = obj["SystemCreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI del sistema padre al que pertenece este adaptador gráfico";

            gpu_SystemName = obj["SystemName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre del equipo donde está instalado el adaptador gráfico";

            gpu_SystemPaletteEntries = obj["SystemPaletteEntries"]?.ToString()
                ?? "No disponible — No se pudo obtener el número total de entradas de paleta del sistema disponibles en el adaptador gráfico";

            gpu_TimeOfLastReset = obj["TimeOfLastReset"]?.ToString()
                ?? "No disponible — No se pudo obtener la fecha y hora del último reinicio o reseteo del adaptador gráfico";

            gpu_VideoArchitecture = obj["VideoArchitecture"]?.ToString()
                ?? "No disponible — No se pudo identificar la arquitectura de video del adaptador gráfico (ej. VGA, SVGA, PCI, AGP, PCIe)";

            gpu_VideoMemoryType = obj["VideoMemoryType"]?.ToString()
                ?? "No disponible — No se pudo identificar el tipo de memoria de video del adaptador gráfico (ej. GDDR5, GDDR6, HBM)";

            gpu_VideoMode = obj["VideoMode"]?.ToString()
                ?? "No disponible — No se pudo obtener el modo de video actual configurado en el adaptador gráfico";

            gpu_VideoModeDescription = obj["VideoModeDescription"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción completa del modo de video actual del adaptador gráfico (ej. 1920 x 1080 x 4294967296 colores)";

            gpu_VideoProcessor = obj["VideoProcessor"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre del procesador de video integrado en el adaptador gráfico (ej. NVIDIA GA102)";

            gpu___GENUS = obj["__GENUS"]?.ToString()
                ?? "No disponible — No se pudo leer el tipo de objeto WMI del adaptador gráfico (indica si es instancia o definición de clase)";

            gpu___CLASS = obj["__CLASS"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI a la que pertenece este adaptador gráfico";

            gpu___SUPERCLASS = obj["__SUPERCLASS"]?.ToString()
                ?? "No disponible — No se pudo determinar la clase padre WMI de la que hereda Win32_VideoController";

            gpu___DYNASTY = obj["__DYNASTY"]?.ToString()
                ?? "No disponible — No se pudo obtener la clase raíz de la jerarquía WMI a la que pertenece este adaptador gráfico";

            gpu___RELPATH = obj["__RELPATH"]?.ToString()
                ?? "No disponible — No se pudo obtener la ruta relativa WMI que identifica de forma única este adaptador gráfico";

            gpu___PROPERTY_COUNT = obj["__PROPERTY_COUNT"]?.ToString()
                ?? "No disponible — No se pudo determinar el número total de propiedades WMI expuestas por este adaptador gráfico";

            gpu___DERIVATION = obj["__DERIVATION"]?.ToString()
                ?? "No disponible — No se pudo obtener la cadena completa de herencia de clases WMI del adaptador gráfico";

            gpu___SERVER = obj["__SERVER"]?.ToString()
                ?? "No disponible — No se pudo identificar el nombre del servidor WMI desde el que se obtuvo la información del adaptador gráfico";

            gpu___NAMESPACE = obj["__NAMESPACE"]?.ToString()
                ?? "No disponible — No se pudo obtener el namespace WMI donde reside la clase Win32_VideoController (ej. root\\cimv2)";

            gpu___PATH = obj["__PATH"]?.ToString()
                ?? "No disponible — No se pudo construir la ruta completa WMI que identifica de forma única este adaptador gráfico en el sistema";
        }
        busqueda = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
        foreach (ManagementObject obj in busqueda.Get())
        {
            so_BootDevice = obj["BootDevice"]?.ToString()
                ?? "No disponible — No se pudo obtener el dispositivo desde el cual arrancó el sistema operativo (ej. \\Device\\HarddiskVolume1)";

            so_BuildNumber = obj["BuildNumber"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de compilación del sistema operativo (ej. 22621 para Windows 11)";

            so_BuildType = obj["BuildType"]?.ToString()
                ?? "No disponible — No se pudo determinar el tipo de compilación del sistema operativo (ej. Multiprocessor Free)";

            so_Caption = obj["Caption"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre completo del sistema operativo (ej. Microsoft Windows 11 Pro)";

            so_CodeSet = obj["CodeSet"]?.ToString()
                ?? "No disponible — No se pudo obtener el conjunto de códigos de caracteres utilizado por el sistema operativo (ej. 1252 para Western European)";

            so_CountryCode = obj["CountryCode"]?.ToString()
                ?? "No disponible — No se pudo obtener el código de país configurado en el sistema operativo (ej. 52 para México)";

            so_CreationClassName = obj["CreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI utilizada para crear esta instancia del sistema operativo";

            so_CSCreationClassName = obj["CSCreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI del sistema de cómputo al que pertenece este sistema operativo";

            so_CSDVersion = obj["CSDVersion"]?.ToString()
                ?? "No disponible — No se pudo obtener la versión del Service Pack instalado en el sistema operativo";

            so_CSName = obj["CSName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre del equipo donde está instalado el sistema operativo";

            so_CurrentTimeZone = obj["CurrentTimeZone"]?.ToString()
                ?? "No disponible — No se pudo obtener la zona horaria actual del sistema operativo en minutos respecto a UTC";

            so_DataExecutionPrevention_32BitApplications = obj["DataExecutionPrevention_32BitApplications"]?.ToString()
                ?? "No disponible — No se pudo determinar si la Prevención de Ejecución de Datos (DEP) está activa para aplicaciones de 32 bits";

            so_DataExecutionPrevention_Available = obj["DataExecutionPrevention_Available"]?.ToString()
                ?? "No disponible — No se pudo determinar si el hardware soporta la función de Prevención de Ejecución de Datos (DEP)";

            so_DataExecutionPrevention_Drivers = obj["DataExecutionPrevention_Drivers"]?.ToString()
                ?? "No disponible — No se pudo determinar si la Prevención de Ejecución de Datos (DEP) está activa para los controladores del sistema";

            so_DataExecutionPrevention_SupportPolicy = obj["DataExecutionPrevention_SupportPolicy"]?.ToString()
                ?? "No disponible — No se pudo obtener la política de soporte de DEP configurada en el sistema operativo (ej. OptIn, OptOut, AlwaysOn)";

            so_Debug = obj["Debug"]?.ToString()
                ?? "No disponible — No se pudo determinar si el sistema operativo fue compilado con información de depuración habilitada";

            so_Description = obj["Description"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción adicional del sistema operativo proporcionada por el administrador";

            so_Distributed = obj["Distributed"]?.ToString()
                ?? "No disponible — No se pudo determinar si el sistema operativo forma parte de un entorno distribuido";

            so_EncryptionLevel = obj["EncryptionLevel"]?.ToString()
                ?? "No disponible — No se pudo obtener el nivel de cifrado soportado por el sistema operativo en bits (ej. 40, 128, 256)";

            so_ForegroundApplicationBoost = obj["ForegroundApplicationBoost"]?.ToString()
                ?? "No disponible — No se pudo obtener el nivel de prioridad adicional asignado a las aplicaciones en primer plano por el sistema operativo";

            so_FreePhysicalMemory = obj["FreePhysicalMemory"]?.ToString()
                ?? "No disponible — No se pudo obtener la cantidad de memoria RAM física disponible actualmente en el sistema en KB";

            so_FreeSpaceInPagingFiles = obj["FreeSpaceInPagingFiles"]?.ToString()
                ?? "No disponible — No se pudo obtener el espacio libre disponible en los archivos de paginación del sistema operativo en KB";

            so_FreeVirtualMemory = obj["FreeVirtualMemory"]?.ToString()
                ?? "No disponible — No se pudo obtener la cantidad de memoria virtual libre disponible actualmente en el sistema en KB";

            so_InstallDate = obj["InstallDate"]?.ToString()
                ?? "No disponible — No se pudo obtener la fecha y hora en que fue instalado el sistema operativo en este equipo";

            so_LargeSystemCache = obj["LargeSystemCache"]?.ToString()
                ?? "No disponible — No se pudo determinar si el sistema operativo está configurado para usar una caché de sistema grande";

            so_LastBootUpTime = obj["LastBootUpTime"]?.ToString()
                ?? "No disponible — No se pudo obtener la fecha y hora del último inicio del sistema operativo";

            so_LocalDateTime = obj["LocalDateTime"]?.ToString()
                ?? "No disponible — No se pudo obtener la fecha y hora local actual del sistema operativo en el momento de la consulta";

            so_Locale = obj["Locale"]?.ToString()
                ?? "No disponible — No se pudo obtener el código de configuración regional del sistema operativo en formato hexadecimal (ej. 080A para español México)";

            so_Manufacturer = obj["Manufacturer"]?.ToString()
                ?? "No disponible — No se pudo obtener el fabricante del sistema operativo (ej. Microsoft Corporation)";

            so_MaxNumberOfProcesses = obj["MaxNumberOfProcesses"]?.ToString()
                ?? "No disponible — No se pudo obtener el número máximo de procesos que puede ejecutar simultáneamente el sistema operativo";

            so_MaxProcessMemorySize = obj["MaxProcessMemorySize"]?.ToString()
                ?? "No disponible — No se pudo obtener la cantidad máxima de memoria en KB que puede usar un proceso individual en este sistema operativo";

            so_MUILanguages = obj["MUILanguages"]?.ToString()
                ?? "No disponible — No se pudieron obtener los idiomas de interfaz de usuario MUI instalados en el sistema operativo";

            so_Name = obj["Name"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre completo del sistema operativo incluyendo la partición donde está instalado";

            so_NumberOfLicensedUsers = obj["NumberOfLicensedUsers"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de usuarios con licencia configurados en el sistema operativo";

            so_NumberOfProcesses = obj["NumberOfProcesses"]?.ToString()
                ?? "No disponible — No se pudo obtener el número total de procesos actualmente en ejecución en el sistema operativo";

            so_NumberOfUsers = obj["NumberOfUsers"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de sesiones de usuario actualmente activas en el sistema operativo";

            so_OperatingSystemSKU = obj["OperatingSystemSKU"]?.ToString()
                ?? "No disponible — No se pudo obtener el código SKU del sistema operativo que identifica la edición exacta (ej. 48=Pro, 4=Enterprise)";

            so_Organization = obj["Organization"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la organización registrada en la licencia del sistema operativo";

            so_OSArchitecture = obj["OSArchitecture"]?.ToString()
                ?? "No disponible — No se pudo determinar la arquitectura del sistema operativo instalado (ej. 32 bits o 64 bits)";

            so_OSLanguage = obj["OSLanguage"]?.ToString()
                ?? "No disponible — No se pudo obtener el código de idioma principal del sistema operativo en formato LCID (ej. 2058 para español México)";

            so_OSProductSuite = obj["OSProductSuite"]?.ToString()
                ?? "No disponible — No se pudo obtener el código de la suite de productos del sistema operativo instalada";

            so_OSType = obj["OSType"]?.ToString()
                ?? "No disponible — No se pudo obtener el tipo de sistema operativo según la clasificación WMI (ej. 18=WINNT)";

            so_OtherTypeDescription = obj["OtherTypeDescription"]?.ToString()
                ?? "No disponible — No hay descripción adicional de tipo disponible, este campo solo aplica cuando OSType no está en la lista estándar";

            so_PAEEnabled = obj["PAEEnabled"]?.ToString()
                ?? "No disponible — No se pudo determinar si la Extensión de Dirección Física (PAE) está habilitada en el sistema operativo";

            so_PlusProductID = obj["PlusProductID"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador del producto Plus instalado junto al sistema operativo";

            so_PlusVersionNumber = obj["PlusVersionNumber"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de versión del producto Plus instalado junto al sistema operativo";

            so_PortableOperatingSystem = obj["PortableOperatingSystem"]?.ToString()
                ?? "No disponible — No se pudo determinar si el sistema operativo está ejecutándose desde un dispositivo portátil (ej. USB)";

            so_Primary = obj["Primary"]?.ToString()
                ?? "No disponible — No se pudo determinar si este es el sistema operativo principal instalado en el equipo";

            so_ProductType = obj["ProductType"]?.ToString()
                ?? "No disponible — No se pudo obtener el tipo de producto del sistema operativo (ej. 1=Workstation, 2=Domain Controller, 3=Server)";

            so_RegisteredUser = obj["RegisteredUser"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre del usuario registrado en la licencia del sistema operativo";

            so_SerialNumber = obj["SerialNumber"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de serie o clave de producto del sistema operativo";

            so_ServicePackMajorVersion = obj["ServicePackMajorVersion"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de versión mayor del Service Pack instalado en el sistema operativo";

            so_ServicePackMinorVersion = obj["ServicePackMinorVersion"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de versión menor del Service Pack instalado en el sistema operativo";

            so_SizeStoredInPagingFiles = obj["SizeStoredInPagingFiles"]?.ToString()
                ?? "No disponible — No se pudo obtener el tamaño total en KB almacenado actualmente en los archivos de paginación del sistema";

            so_Status = obj["Status"]?.ToString()
                ?? "No disponible — No se pudo obtener el estado general de operación del sistema operativo (ej. OK, Error, Degradado)";

            so_SuiteMask = obj["SuiteMask"]?.ToString()
                ?? "No disponible — No se pudo obtener la máscara de bits que identifica las suites de software instaladas junto al sistema operativo";

            so_SystemDevice = obj["SystemDevice"]?.ToString()
                ?? "No disponible — No se pudo obtener el dispositivo físico donde está almacenado el sistema operativo (ej. \\Device\\HarddiskVolume2)";

            so_SystemDirectory = obj["SystemDirectory"]?.ToString()
                ?? "No disponible — No se pudo obtener la ruta del directorio del sistema operativo (ej. C:\\Windows\\system32)";

            so_SystemDrive = obj["SystemDrive"]?.ToString()
                ?? "No disponible — No se pudo obtener la letra de la unidad donde está instalado el sistema operativo (ej. C:)";

            so_TotalSwapSpaceSize = obj["TotalSwapSpaceSize"]?.ToString()
                ?? "No disponible — No se pudo obtener el tamaño total del espacio de intercambio disponible en el sistema en KB";

            so_TotalVirtualMemorySize = obj["TotalVirtualMemorySize"]?.ToString()
                ?? "No disponible — No se pudo obtener el tamaño total de la memoria virtual disponible en el sistema en KB (RAM + paginación)";

            so_TotalVisibleMemorySize = obj["TotalVisibleMemorySize"]?.ToString()
                ?? "No disponible — No se pudo obtener la cantidad total de memoria RAM física visible para el sistema operativo en KB";

            so_Version = obj["Version"]?.ToString()
                ?? "No disponible — No se pudo obtener el número de versión del sistema operativo (ej. 10.0.22621 para Windows 11)";

            so_WindowsDirectory = obj["WindowsDirectory"]?.ToString()
                ?? "No disponible — No se pudo obtener la ruta del directorio raíz de Windows (ej. C:\\Windows)";

            so___GENUS = obj["__GENUS"]?.ToString()
                ?? "No disponible — No se pudo leer el tipo de objeto WMI del sistema operativo (indica si es instancia o definición de clase)";

            so___CLASS = obj["__CLASS"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI a la que pertenece este sistema operativo";

            so___SUPERCLASS = obj["__SUPERCLASS"]?.ToString()
                ?? "No disponible — No se pudo determinar la clase padre WMI de la que hereda Win32_OperatingSystem";

            so___DYNASTY = obj["__DYNASTY"]?.ToString()
                ?? "No disponible — No se pudo obtener la clase raíz de la jerarquía WMI a la que pertenece este sistema operativo";

            so___RELPATH = obj["__RELPATH"]?.ToString()
                ?? "No disponible — No se pudo obtener la ruta relativa WMI que identifica de forma única este sistema operativo";

            so___PROPERTY_COUNT = obj["__PROPERTY_COUNT"]?.ToString()
                ?? "No disponible — No se pudo determinar el número total de propiedades WMI expuestas por este sistema operativo";

            so___DERIVATION = obj["__DERIVATION"]?.ToString()
                ?? "No disponible — No se pudo obtener la cadena completa de herencia de clases WMI del sistema operativo";

            so___SERVER = obj["__SERVER"]?.ToString()
                ?? "No disponible — No se pudo identificar el nombre del servidor WMI desde el que se obtuvo la información del sistema operativo";

            so___NAMESPACE = obj["__NAMESPACE"]?.ToString()
                ?? "No disponible — No se pudo obtener el namespace WMI donde reside la clase Win32_OperatingSystem (ej. root\\cimv2)";

            so___PATH = obj["__PATH"]?.ToString()
                ?? "No disponible — No se pudo construir la ruta completa WMI que identifica de forma única este sistema operativo en el sistema";
        }

        busqueda = new ManagementObjectSearcher("SELECT * FROM Win32_NetworkAdapter");
        foreach (ManagementObject obj in busqueda.Get())
        {
            net_AdapterType = obj["AdapterType"]?.ToString()
                ?? "No disponible — No se pudo identificar el tipo de adaptador de red (ej. Ethernet 802.3, Wireless LAN, Bluetooth)";

            net_AdapterTypeId = obj["AdapterTypeId"]?.ToString()
                ?? "No disponible — No se pudo obtener el código numérico que identifica el tipo de adaptador de red según el estándar WMI";

            net_AutoSense = obj["AutoSense"]?.ToString()
                ?? "No disponible — No se pudo determinar si el adaptador de red detecta automáticamente la velocidad y modo dúplex de la conexión";

            net_Availability = obj["Availability"]?.ToString()
                ?? "No disponible — No se pudo determinar el estado de disponibilidad operativa del adaptador de red (ej. En uso, En espera, Apagado)";

            net_Caption = obj["Caption"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción corta del adaptador de red proporcionada por el sistema";

            net_ConfigManagerErrorCode = obj["ConfigManagerErrorCode"]?.ToString()
                ?? "No disponible — No se pudo obtener el código de error del Administrador de Configuración de Windows para el adaptador de red";

            net_ConfigManagerUserConfig = obj["ConfigManagerUserConfig"]?.ToString()
                ?? "No disponible — No se pudo determinar si el adaptador de red tiene configuración personalizada en el Administrador de Configuración";

            net_CreationClassName = obj["CreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI utilizada para crear esta instancia del adaptador de red";

            net_Description = obj["Description"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción detallada del adaptador de red proporcionada por el sistema";

            net_DeviceID = obj["DeviceID"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador único del dispositivo asignado al adaptador de red por el sistema";

            net_ErrorCleared = obj["ErrorCleared"]?.ToString()
                ?? "No disponible — No se pudo determinar si el último error registrado en el adaptador de red fue limpiado o sigue activo";

            net_ErrorDescription = obj["ErrorDescription"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción del último error registrado por el adaptador de red";

            net_GUID = obj["GUID"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador único global (GUID) asignado al adaptador de red por Windows";

            net_Index = obj["Index"]?.ToString()
                ?? "No disponible — No se pudo obtener el índice numérico que identifica la posición del adaptador de red en el sistema";

            net_InstallDate = obj["InstallDate"]?.ToString()
                ?? "No disponible — El sistema no registra una fecha de instalación para el adaptador de red, este campo generalmente es nulo";

            net_Installed = obj["Installed"]?.ToString()
                ?? "No disponible — No se pudo determinar si el adaptador de red está correctamente instalado en el sistema";

            net_InterfaceIndex = obj["InterfaceIndex"]?.ToString()
                ?? "No disponible — No se pudo obtener el índice de interfaz de red asignado por el sistema operativo al adaptador";

            net_LastErrorCode = obj["LastErrorCode"]?.ToString()
                ?? "No disponible — No se pudo recuperar el código numérico del último error reportado por el adaptador de red";

            net_MACAddress = obj["MACAddress"]?.ToString()
                ?? "No disponible — No se pudo obtener la dirección MAC física del adaptador de red (identificador único de hardware de 6 bytes)";

            net_Manufacturer = obj["Manufacturer"]?.ToString()
                ?? "No disponible — No se pudo identificar el fabricante del adaptador de red (ej. Intel, Realtek, Broadcom, Qualcomm)";

            net_MaxNumberControlled = obj["MaxNumberControlled"]?.ToString()
                ?? "No disponible — No se pudo obtener el número máximo de dispositivos controlados directamente por el adaptador de red";

            net_MaxSpeed = obj["MaxSpeed"]?.ToString()
                ?? "No disponible — No se pudo obtener la velocidad máxima teórica soportada por el adaptador de red en bits por segundo";

            net_Name = obj["Name"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre completo del adaptador de red reportado por el fabricante";

            net_NetConnectionID = obj["NetConnectionID"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la conexión de red asignado por el usuario en Windows (ej. Ethernet, Wi-Fi)";

            net_NetConnectionStatus = obj["NetConnectionStatus"]?.ToString()
                ?? "No disponible — No se pudo obtener el estado actual de la conexión de red (ej. 2=Conectado, 7=Desconectado, 0=Desconectado)";

            net_NetEnabled = obj["NetEnabled"]?.ToString()
                ?? "No disponible — No se pudo determinar si el adaptador de red está actualmente habilitado en el sistema operativo";

            net_NetworkAddresses = obj["NetworkAddresses"]?.ToString()
                ?? "No disponible — No se pudieron obtener las direcciones de red asignadas actualmente al adaptador";

            net_PermanentAddress = obj["PermanentAddress"]?.ToString()
                ?? "No disponible — No se pudo obtener la dirección MAC permanente grabada en el hardware del adaptador de red por el fabricante";

            net_PhysicalAdapter = obj["PhysicalAdapter"]?.ToString()
                ?? "No disponible — No se pudo determinar si el adaptador de red corresponde a un dispositivo físico real o es un adaptador virtual";

            net_PNPDeviceID = obj["PNPDeviceID"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador Plug and Play asignado al adaptador de red por Windows";

            net_PowerManagementCapabilities = obj["PowerManagementCapabilities"]?.ToString()
                ?? "No disponible — No se pudieron obtener las capacidades de administración de energía soportadas por el adaptador de red";

            net_PowerManagementSupported = obj["PowerManagementSupported"]?.ToString()
                ?? "No disponible — No se pudo determinar si el adaptador de red soporta funciones de administración de energía (ej. Wake-on-LAN)";

            net_ProductName = obj["ProductName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre comercial del producto del adaptador de red reportado por el fabricante";

            net_ServiceName = obj["ServiceName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre del servicio de Windows asociado al controlador del adaptador de red";

            net_Speed = obj["Speed"]?.ToString()
                ?? "No disponible — No se pudo obtener la velocidad actual de operación del adaptador de red en bits por segundo";

            net_Status = obj["Status"]?.ToString()
                ?? "No disponible — No se pudo obtener el estado general de operación del adaptador de red (ej. OK, Error, Degradado)";

            net_StatusInfo = obj["StatusInfo"]?.ToString()
                ?? "No disponible — No se pudo obtener el código numérico que describe el estado de operación del adaptador de red";

            net_SystemCreationClassName = obj["SystemCreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI del sistema padre al que pertenece este adaptador de red";

            net_SystemName = obj["SystemName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre del equipo donde está instalado el adaptador de red";

            net_TimeOfLastReset = obj["TimeOfLastReset"]?.ToString()
                ?? "No disponible — No se pudo obtener la fecha y hora del último reinicio o reseteo del adaptador de red";

            net___GENUS = obj["__GENUS"]?.ToString()
                ?? "No disponible — No se pudo leer el tipo de objeto WMI del adaptador de red (indica si es instancia o definición de clase)";

            net___CLASS = obj["__CLASS"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI a la que pertenece este adaptador de red";

            net___SUPERCLASS = obj["__SUPERCLASS"]?.ToString()
                ?? "No disponible — No se pudo determinar la clase padre WMI de la que hereda Win32_NetworkAdapter";

            net___DYNASTY = obj["__DYNASTY"]?.ToString()
                ?? "No disponible — No se pudo obtener la clase raíz de la jerarquía WMI a la que pertenece este adaptador de red";

            net___RELPATH = obj["__RELPATH"]?.ToString()
                ?? "No disponible — No se pudo obtener la ruta relativa WMI que identifica de forma única este adaptador de red";

            net___PROPERTY_COUNT = obj["__PROPERTY_COUNT"]?.ToString()
                ?? "No disponible — No se pudo determinar el número total de propiedades WMI expuestas por este adaptador de red";

            net___DERIVATION = obj["__DERIVATION"]?.ToString()
                ?? "No disponible — No se pudo obtener la cadena completa de herencia de clases WMI del adaptador de red";

            net___SERVER = obj["__SERVER"]?.ToString()
                ?? "No disponible — No se pudo identificar el nombre del servidor WMI desde el que se obtuvo la información del adaptador de red";

            net___NAMESPACE = obj["__NAMESPACE"]?.ToString()
                ?? "No disponible — No se pudo obtener el namespace WMI donde reside la clase Win32_NetworkAdapter (ej. root\\cimv2)";

            net___PATH = obj["__PATH"]?.ToString()
                ?? "No disponible — No se pudo construir la ruta completa WMI que identifica de forma única este adaptador de red en el sistema";
        }
        busqueda = new ManagementObjectSearcher("SELECT * FROM Win32_Battery");
        foreach (ManagementObject obj in busqueda.Get())
        {
            bat_Availability = obj["Availability"]?.ToString()
                ?? "No disponible — No se pudo determinar el estado de disponibilidad operativa de la batería (ej. En uso, En espera, Apagado) o el equipo no tiene batería";

            bat_BatteryRechargeTime = obj["BatteryRechargeTime"]?.ToString()
                ?? "No disponible — No se pudo obtener el tiempo estimado en minutos que tarda la batería en recargarse completamente desde vacío";

            bat_BatteryStatus = obj["BatteryStatus"]?.ToString()
                ?? "No disponible — No se pudo obtener el estado actual de la batería (ej. 1=Descargando, 2=En CA, 3=Cargando completamente, 6=Cargando)";

            bat_Caption = obj["Caption"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción corta de la batería proporcionada por el sistema";

            bat_Chemistry = obj["Chemistry"]?.ToString()
                ?? "No disponible — No se pudo identificar el tipo de química de la batería (ej. 2=Plomo-ácido, 3=NiCd, 4=NiMH, 5=Li-ion, 6=NiZn, 7=LiPo)";

            bat_ConfigManagerErrorCode = obj["ConfigManagerErrorCode"]?.ToString()
                ?? "No disponible — No se pudo obtener el código de error del Administrador de Configuración de Windows para la batería";

            bat_ConfigManagerUserConfig = obj["ConfigManagerUserConfig"]?.ToString()
                ?? "No disponible — No se pudo determinar si la batería tiene configuración personalizada en el Administrador de Configuración de Windows";

            bat_CreationClassName = obj["CreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI utilizada para crear esta instancia de la batería";

            bat_Description = obj["Description"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción detallada de la batería proporcionada por el sistema";

            bat_DesignCapacity = obj["DesignCapacity"]?.ToString()
                ?? "No disponible — No se pudo obtener la capacidad de diseño original de la batería en mWh reportada por el fabricante";

            bat_DesignVoltage = obj["DesignVoltage"]?.ToString()
                ?? "No disponible — No se pudo obtener el voltaje de diseño nominal de la batería en milivolts reportado por el fabricante";

            bat_DeviceID = obj["DeviceID"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador único del dispositivo asignado a la batería por el sistema";

            bat_ErrorCleared = obj["ErrorCleared"]?.ToString()
                ?? "No disponible — No se pudo determinar si el último error registrado en la batería fue limpiado o sigue activo";

            bat_ErrorDescription = obj["ErrorDescription"]?.ToString()
                ?? "No disponible — No se pudo obtener la descripción del último error registrado por la batería";

            bat_EstimatedChargeRemaining = obj["EstimatedChargeRemaining"]?.ToString()
                ?? "No disponible — No se pudo obtener el porcentaje de carga restante estimado actualmente en la batería";

            bat_EstimatedRunTime = obj["EstimatedRunTime"]?.ToString()
                ?? "No disponible — No se pudo obtener el tiempo estimado en minutos que puede operar el equipo con la carga actual de la batería";

            bat_ExpectedBatteryLife = obj["ExpectedBatteryLife"]?.ToString()
                ?? "No disponible — No se pudo obtener la vida útil esperada de la batería en minutos bajo condiciones normales de uso";

            bat_ExpectedLife = obj["ExpectedLife"]?.ToString()
                ?? "No disponible — No se pudo obtener la vida útil total esperada de la batería en minutos desde su fabricación";

            bat_FullChargeCapacity = obj["FullChargeCapacity"]?.ToString()
                ?? "No disponible — No se pudo obtener la capacidad máxima actual de carga completa de la batería en mWh (puede diferir del diseño original por desgaste)";

            bat_InstallDate = obj["InstallDate"]?.ToString()
                ?? "No disponible — El sistema no registra una fecha de instalación para la batería, este campo generalmente es nulo";

            bat_LastErrorCode = obj["LastErrorCode"]?.ToString()
                ?? "No disponible — No se pudo recuperar el código numérico del último error reportado por la batería";

            bat_MaxRechargeTime = obj["MaxRechargeTime"]?.ToString()
                ?? "No disponible — No se pudo obtener el tiempo máximo en minutos que puede tardar la batería en recargarse completamente";

            bat_Name = obj["Name"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre del dispositivo de batería asignado por el sistema o el fabricante";

            bat_PNPDeviceID = obj["PNPDeviceID"]?.ToString()
                ?? "No disponible — No se pudo obtener el identificador Plug and Play asignado a la batería por Windows";

            bat_PowerManagementCapabilities = obj["PowerManagementCapabilities"]?.ToString()
                ?? "No disponible — No se pudieron obtener las capacidades de administración de energía soportadas por la batería";

            bat_PowerManagementSupported = obj["PowerManagementSupported"]?.ToString()
                ?? "No disponible — No se pudo determinar si la batería soporta funciones de administración de energía del sistema";

            bat_SmartBatteryVersion = obj["SmartBatteryVersion"]?.ToString()
                ?? "No disponible — No se pudo obtener la versión del estándar Smart Battery implementado en la batería para comunicarse con el sistema";

            bat_Status = obj["Status"]?.ToString()
                ?? "No disponible — No se pudo obtener el estado general de operación de la batería (ej. OK, Error, Degradado)";

            bat_StatusInfo = obj["StatusInfo"]?.ToString()
                ?? "No disponible — No se pudo obtener el código numérico que describe el estado de operación de la batería";

            bat_SystemCreationClassName = obj["SystemCreationClassName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI del sistema padre al que pertenece esta batería";

            bat_SystemName = obj["SystemName"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre del equipo donde está instalada la batería";

            bat_TimeOnBattery = obj["TimeOnBattery"]?.ToString()
                ?? "No disponible — No se pudo obtener el tiempo en segundos que el equipo lleva funcionando con la batería sin estar conectado a la corriente";

            bat_TimeToFullCharge = obj["TimeToFullCharge"]?.ToString()
                ?? "No disponible — No se pudo obtener el tiempo estimado en minutos que falta para que la batería alcance su carga completa";

            bat___GENUS = obj["__GENUS"]?.ToString()
                ?? "No disponible — No se pudo leer el tipo de objeto WMI de la batería (indica si es instancia o definición de clase)";

            bat___CLASS = obj["__CLASS"]?.ToString()
                ?? "No disponible — No se pudo obtener el nombre de la clase WMI a la que pertenece esta batería";

            bat___SUPERCLASS = obj["__SUPERCLASS"]?.ToString()
                ?? "No disponible — No se pudo determinar la clase padre WMI de la que hereda Win32_Battery";

            bat___DYNASTY = obj["__DYNASTY"]?.ToString()
                ?? "No disponible — No se pudo obtener la clase raíz de la jerarquía WMI a la que pertenece esta batería";

            bat___RELPATH = obj["__RELPATH"]?.ToString()
                ?? "No disponible — No se pudo obtener la ruta relativa WMI que identifica de forma única esta batería";

            bat___PROPERTY_COUNT = obj["__PROPERTY_COUNT"]?.ToString()
                ?? "No disponible — No se pudo determinar el número total de propiedades WMI expuestas por esta batería";

            bat___DERIVATION = obj["__DERIVATION"]?.ToString()
                ?? "No disponible — No se pudo obtener la cadena completa de herencia de clases WMI de la batería";

            bat___SERVER = obj["__SERVER"]?.ToString()
                ?? "No disponible — No se pudo identificar el nombre del servidor WMI desde el que se obtuvo la información de la batería";

            bat___NAMESPACE = obj["__NAMESPACE"]?.ToString()
                ?? "No disponible — No se pudo obtener el namespace WMI donde reside la clase Win32_Battery (ej. root\\cimv2)";

            bat___PATH = obj["__PATH"]?.ToString()
                ?? "No disponible — No se pudo construir la ruta completa WMI que identifica de forma única esta batería en el sistema";
        }
    }
}



