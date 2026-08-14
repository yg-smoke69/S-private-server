using Il2CppDummyDll;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000BAF")]
public static class ExportUtil
{
	[Token(Token = "0x4006232")]
	[FieldOffset(Offset = "0x0")]
	public static string ExportError;

	[Token(Token = "0x6005865")]
	[Address(RVA = "0x37BDF7C", Offset = "0x37BDF7C", VA = "0x37BDF7C")]
	public static bool FillValue(BlockEditContext context, ValueData value, IOGCEGJJHLK targetValueType, EGKJIDMCGML result)
	{
		return default(bool);
	}

	[Token(Token = "0x6005866")]
	[Address(RVA = "0x37BE770", Offset = "0x37BE770", VA = "0x37BE770")]
	public static bool ExportAs(BlockEditContext context, BlockData source, EGKJIDMCGML result)
	{
		return default(bool);
	}

	[Token(Token = "0x6005867")]
	[Address(RVA = "0x37BE964", Offset = "0x37BE964", VA = "0x37BE964")]
	public static EGKJIDMCGML ExportCurrentGraphId(BlockEditContext context)
	{
		return null;
	}

	[Token(Token = "0x6005868")]
	[Address(RVA = "0x37BB3E8", Offset = "0x37BB3E8", VA = "0x37BB3E8")]
	public static EGKJIDMCGML ExportGlobalGraphId(BlockEditContext context)
	{
		return null;
	}

	[Token(Token = "0x6005869")]
	[Address(RVA = "0x37BB0E4", Offset = "0x37BB0E4", VA = "0x37BB0E4")]
	public static KDNPLMHKBHC ExportGetEntity(string ownerGraphId, string entityId)
	{
		return null;
	}

	[Token(Token = "0x600586A")]
	[Address(RVA = "0x37A6268", Offset = "0x37A6268", VA = "0x37A6268")]
	public static KDNPLMHKBHC ExportGetEntity(string ownerGraphId, EGKJIDMCGML entityId)
	{
		return null;
	}

	[Token(Token = "0x600586B")]
	[Address(RVA = "0x37BAF54", Offset = "0x37BAF54", VA = "0x37BAF54")]
	public static EGKJIDMCGML ExportGlobalEntity(string ownerGraphId)
	{
		return null;
	}

	[Token(Token = "0x600586C")]
	[Address(RVA = "0x37A6188", Offset = "0x37A6188", VA = "0x37A6188")]
	public static EGKJIDMCGML ExportGetThisEntityReplicationData(string ownerGraphId, int propertyIndex)
	{
		return null;
	}

	[Token(Token = "0x600586D")]
	[Address(RVA = "0x37BEC18", Offset = "0x37BEC18", VA = "0x37BEC18")]
	public static EGKJIDMCGML ExportGetReplicationData(string ownerGraphId, EGKJIDMCGML entity, int propertyIndex)
	{
		return null;
	}

	[Token(Token = "0x600586E")]
	[Address(RVA = "0x37BEED4", Offset = "0x37BEED4", VA = "0x37BEED4")]
	public static NBDBJJNBJEF ExportGetReplicationDataV2(string ownerGraphId, EGKJIDMCGML entity, int propertyIndex)
	{
		return null;
	}

	[Token(Token = "0x600586F")]
	[Address(RVA = "0x37BEA88", Offset = "0x37BEA88", VA = "0x37BEA88")]
	public static EGKJIDMCGML ExportThisEntity(string ownerGraphId)
	{
		return null;
	}

	[Token(Token = "0x6005870")]
	[Address(RVA = "0x37A5950", Offset = "0x37A5950", VA = "0x37A5950")]
	public static bool NeedExtraCodeBlock(BlockData source)
	{
		return default(bool);
	}

	[Token(Token = "0x6005871")]
	[Address(RVA = "0x37A55FC", Offset = "0x37A55FC", VA = "0x37A55FC")]
	public static OverrideExportReport TakeOverExportBlockData(BlockEditContext context, BlockData source, KDNPLMHKBHC result)
	{
		return default(OverrideExportReport);
	}

	[Token(Token = "0x6005872")]
	[Address(RVA = "0x37A6694", Offset = "0x37A6694", VA = "0x37A6694")]
	public static OverrideExportReport OverrideExportBlockData(BlockEditContext context, BlockData source, KDNPLMHKBHC result)
	{
		return default(OverrideExportReport);
	}

	[Token(Token = "0x6005873")]
	[Address(RVA = "0x37A60A0", Offset = "0x37A60A0", VA = "0x37A60A0")]
	public static string ExportLocalVarName(string varName, string varId)
	{
		return null;
	}

	[Token(Token = "0x6005874")]
	[Address(RVA = "0x37A63F4", Offset = "0x37A63F4", VA = "0x37A63F4")]
	public static EGKJIDMCGML GetLocalVar(string ownerGraphId, string varName, string varId)
	{
		return null;
	}
}
