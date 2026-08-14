using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC;

[Token(Token = "0x2000CEC")]
public static class UGCLocalFileUtil
{
	[Token(Token = "0x4006875")]
	private const string PROJECT_FILENAME_TEMPLATE = "{0}/ProjectData_slot_{1}.bytes";

	[Token(Token = "0x4006876")]
	private const string PROJECT_META_FILENAME_TEMPLATE = "{0}/ProjectData_slot_{1}.meta";

	[Token(Token = "0x4006877")]
	private const string PROJECT_META_JSON_FILENAME_TEMPLATE = "{0}/ProjectData_slot_{1}.meta.json";

	[Token(Token = "0x4006878")]
	private const string RUNTIME_FILENAME_TEMPLATE = "{0}/UserLevelData_{1}.bytes";

	[Token(Token = "0x4006879")]
	private const string RUNTIME_DEBUG_JSON_FILENAME_TEMPLATE = "{0}/UserLevelData_{1}.json";

	[Token(Token = "0x400687A")]
	private const string OLD_WORKSHOP_BIN_FILENAME_TEMPLATE = "{0}/workshop.bin";

	[Token(Token = "0x400687B")]
	private const string OLD_WORKSHOP_INFO_FILENAME_TEMPLATE = "{0}/workshop_info.json";

	[Token(Token = "0x400687C")]
	private const string OLD_JSON_FILENAME_TEMPLATE = "{0}/workshop_1.json";

	[Token(Token = "0x400687D")]
	private const uint TEMP_SLOT_ID = 999u;

	[Token(Token = "0x60061E7")]
	[Address(RVA = "0x25868FC", Offset = "0x25868FC", VA = "0x25868FC")]
	public static string GetJsonFileNameBeforeMoving()
	{
		return null;
	}

	[Token(Token = "0x60061E8")]
	[Address(RVA = "0x2586ABC", Offset = "0x2586ABC", VA = "0x2586ABC")]
	public static string GetJsonFileNameAfterMoving()
	{
		return null;
	}

	[Token(Token = "0x60061E9")]
	[Address(RVA = "0x2586EAC", Offset = "0x2586EAC", VA = "0x2586EAC")]
	public static string GetWorkShopInfoFileName()
	{
		return null;
	}

	[Token(Token = "0x60061EA")]
	[Address(RVA = "0x2586F88", Offset = "0x2586F88", VA = "0x2586F88")]
	public static string GetWorkShopBinFileName()
	{
		return null;
	}

	[Token(Token = "0x60061EB")]
	[Address(RVA = "0x2587064", Offset = "0x2587064", VA = "0x2587064")]
	public static bool HasInfoAndBinFile()
	{
		return default(bool);
	}

	[Token(Token = "0x60061EC")]
	[Address(RVA = "0x25870D8", Offset = "0x25870D8", VA = "0x25870D8")]
	public static bool HasJsonFile()
	{
		return default(bool);
	}

	[Token(Token = "0x60061ED")]
	[Address(RVA = "0x2587134", Offset = "0x2587134", VA = "0x2587134")]
	public static bool DeleteInfoAndBinFile()
	{
		return default(bool);
	}

	[Token(Token = "0x60061EE")]
	[Address(RVA = "0x25872F0", Offset = "0x25872F0", VA = "0x25872F0")]
	public static bool MoveJsonFileToAccountFolder()
	{
		return default(bool);
	}

	[Token(Token = "0x60061EF")]
	[Address(RVA = "0x2587490", Offset = "0x2587490", VA = "0x2587490")]
	public static bool DeleteJsonFileInAccountFolder()
	{
		return default(bool);
	}

	[Token(Token = "0x60061F0")]
	[Address(RVA = "0x2587618", Offset = "0x2587618", VA = "0x2587618")]
	public static PGBGOAOCGDC GetMetaDataBySlot(uint slotID)
	{
		return null;
	}

	[Token(Token = "0x60061F1")]
	[Address(RVA = "0x2583640", Offset = "0x2583640", VA = "0x2583640")]
	public static FMELCANIDOK GetProjectDataBySlot(uint slotID)
	{
		return null;
	}

	[Token(Token = "0x60061F2")]
	[Address(RVA = "0x2587948", Offset = "0x2587948", VA = "0x2587948")]
	public static bool GetProjectAndRuntimeDataBytesBySlot(uint slotID, out byte[] project, out byte[] runtime)
	{
		return default(bool);
	}

	[Token(Token = "0x60061F3")]
	[Address(RVA = "0x2587C88", Offset = "0x2587C88", VA = "0x2587C88")]
	public static bool SaveProjectMetaDataBySlotID(uint slotID, PGBGOAOCGDC metaData)
	{
		return default(bool);
	}

	[Token(Token = "0x60061F4")]
	[Address(RVA = "0x25880BC", Offset = "0x25880BC", VA = "0x25880BC")]
	public static bool TrySaveMetaAndBytesBySlotId(PGBGOAOCGDC meta, byte[] projectBytes, byte[] runtimeBytes, uint slotID)
	{
		return default(bool);
	}

	[Token(Token = "0x60061F5")]
	[Address(RVA = "0x2588194", Offset = "0x2588194", VA = "0x2588194")]
	public static bool SaveBytesBySlotId(byte[] projectBytes, byte[] runtimeBytes, uint slotID)
	{
		return default(bool);
	}

	[Token(Token = "0x60061F6")]
	[Address(RVA = "0x2588570", Offset = "0x2588570", VA = "0x2588570")]
	public static bool CopySlotLocalSaveFromSrcToDest(uint srcSlotId, uint destSlotId)
	{
		return default(bool);
	}

	[Token(Token = "0x60061F7")]
	[Address(RVA = "0x2588238", Offset = "0x2588238", VA = "0x2588238")]
	public static void RemoveSlotLocalSaveBySlotId(uint slotID)
	{
	}

	[Token(Token = "0x60061F8")]
	[Address(RVA = "0x2588B94", Offset = "0x2588B94", VA = "0x2588B94")]
	public static bool SaveProjectData(uint slotID, byte[] projectDataBytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60061F9")]
	[Address(RVA = "0x25879F8", Offset = "0x25879F8", VA = "0x25879F8")]
	public static bool LoadProjectData(uint slotID, out byte[] projectDataBytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60061FA")]
	[Address(RVA = "0x2587B70", Offset = "0x2587B70", VA = "0x2587B70")]
	public static bool LoadRuntimeData(uint slotID, out byte[] runtimeDataBytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60061FB")]
	[Address(RVA = "0x2587DCC", Offset = "0x2587DCC", VA = "0x2587DCC")]
	public static bool SaveProjectMetaDataInBytes(uint slotID, byte[] projectMetaDataBytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60061FC")]
	[Address(RVA = "0x2587F44", Offset = "0x2587F44", VA = "0x2587F44")]
	public static bool SaveProjectMetaDataInJson(uint slotID, string projectMetaDataText)
	{
		return default(bool);
	}

	[Token(Token = "0x60061FD")]
	[Address(RVA = "0x2588D0C", Offset = "0x2588D0C", VA = "0x2588D0C")]
	public static bool SaveRuntimeData(uint slotID, byte[] runtimeDataBytes)
	{
		return default(bool);
	}

	[Token(Token = "0x60061FE")]
	[Address(RVA = "0x25891C4", Offset = "0x25891C4", VA = "0x25891C4")]
	public static bool SaveRuntimeDebugDataInJson(uint slotID, string runtimeDebugDataText)
	{
		return default(bool);
	}

	[Token(Token = "0x60061FF")]
	[Address(RVA = "0x2586B98", Offset = "0x2586B98", VA = "0x2586B98")]
	private static string GetLocalFilePathInAccountFolder()
	{
		return null;
	}

	[Token(Token = "0x6006200")]
	[Address(RVA = "0x25869D8", Offset = "0x25869D8", VA = "0x25869D8")]
	private static string GetOldLocalFilePath()
	{
		return null;
	}

	[Token(Token = "0x6006201")]
	[Address(RVA = "0x258778C", Offset = "0x258778C", VA = "0x258778C")]
	private static bool ReadBytesFromFile(string fullPath, out byte[] data)
	{
		return default(bool);
	}

	[Token(Token = "0x6006202")]
	[Address(RVA = "0x2588E84", Offset = "0x2588E84", VA = "0x2588E84")]
	private static bool WriteBytesToFile(string fullPath, byte[] data)
	{
		return default(bool);
	}

	[Token(Token = "0x6006203")]
	[Address(RVA = "0x2589024", Offset = "0x2589024", VA = "0x2589024")]
	private static bool WriteTextToFile(string fullPath, string text)
	{
		return default(bool);
	}

	[Token(Token = "0x6006204")]
	[Address(RVA = "0x258933C", Offset = "0x258933C", VA = "0x258933C")]
	private static bool ReadTextFromFile(string fullPath, out string text)
	{
		return default(bool);
	}
}
