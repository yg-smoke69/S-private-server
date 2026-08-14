using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B7C")]
public class BlockData
{
	[Token(Token = "0x4006147")]
	[FieldOffset(Offset = "0x8")]
	public float positionX;

	[Token(Token = "0x4006148")]
	[FieldOffset(Offset = "0xC")]
	public float positionY;

	[Token(Token = "0x4006149")]
	[FieldOffset(Offset = "0x10")]
	public string id;

	[Token(Token = "0x400614A")]
	[FieldOffset(Offset = "0x14")]
	public string blockName;

	[Token(Token = "0x400614B")]
	[FieldOffset(Offset = "0x18")]
	public List<BodyData> bodies;

	[Token(Token = "0x400614C")]
	[FieldOffset(Offset = "0x1C")]
	public List<ValueData> values;

	[Token(Token = "0x400614D")]
	[FieldOffset(Offset = "0x20")]
	public BlockDefine BlockDefine;

	[Token(Token = "0x400614E")]
	[FieldOffset(Offset = "0x24")]
	public IBlockDataContainer Parent;

	[Token(Token = "0x400614F")]
	[FieldOffset(Offset = "0x28")]
	public GraphData Graph;

	[Token(Token = "0x4006150")]
	[FieldOffset(Offset = "0x2C")]
	public bool MissingData;

	[Token(Token = "0x4006151")]
	[FieldOffset(Offset = "0x30")]
	public object UserRef;

	[Token(Token = "0x4006152")]
	[FieldOffset(Offset = "0x34")]
	private string mBlockDescKey;

	[Token(Token = "0x4006153")]
	[FieldOffset(Offset = "0x38")]
	private UGCBlockConfigData mConfigData;

	[Token(Token = "0x4006154")]
	[FieldOffset(Offset = "0x3C")]
	public TypeInfo ReturnType;

	[Token(Token = "0x4006155")]
	[FieldOffset(Offset = "0x44")]
	public Action OnUpdated;

	[Token(Token = "0x4006156")]
	[FieldOffset(Offset = "0x48")]
	public int ChildrenBlockCount;

	[Token(Token = "0x4006157")]
	[FieldOffset(Offset = "0x4C")]
	public bool IsAvailable;

	[Token(Token = "0x4006158")]
	[FieldOffset(Offset = "0x0")]
	private static Func<BlockEditContext, JsonWriter, BodyData, bool> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x4006159")]
	[FieldOffset(Offset = "0x4")]
	private static Func<BlockEditContext, JsonWriter, ValueData, bool> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x400615A")]
	[FieldOffset(Offset = "0x8")]
	private static Func<ValueData, int> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400615B")]
	[FieldOffset(Offset = "0xC")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map5;

	[Token(Token = "0x400615C")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, int> _003C_003Ef__switch_0024map6;

	[Token(Token = "0x170006F6")]
	public string typeName
	{
		[Token(Token = "0x600570C")]
		[Address(RVA = "0x379F908", Offset = "0x379F908", VA = "0x379F908")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F7")]
	public string BlockDescKey
	{
		[Token(Token = "0x600570D")]
		[Address(RVA = "0x379F9F0", Offset = "0x379F9F0", VA = "0x379F9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F8")]
	public UGCBlockConfigData ConfigData
	{
		[Token(Token = "0x600570E")]
		[Address(RVA = "0x379FB08", Offset = "0x379FB08", VA = "0x379FB08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600570B")]
	[Address(RVA = "0x379F8EC", Offset = "0x379F8EC", VA = "0x379F8EC")]
	public BlockData()
	{
	}

	[Token(Token = "0x600570F")]
	[Address(RVA = "0x379FDBC", Offset = "0x379FDBC", VA = "0x379FDBC")]
	public bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005710")]
	[Address(RVA = "0x37A320C", Offset = "0x37A320C", VA = "0x37A320C")]
	public bool ToJsonData(BlockEditContext context, JsonWriter jsonWriter, bool isRootBlock = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6005711")]
	[Address(RVA = "0x37A3890", Offset = "0x37A3890", VA = "0x37A3890")]
	public KDNPLMHKBHC ToExportProtoData(BlockEditContext context)
	{
		return null;
	}

	[Token(Token = "0x6005712")]
	[Address(RVA = "0x37A6A34", Offset = "0x37A6A34", VA = "0x37A6A34")]
	public BlockData Clone(IBlockDataContainer parent, GraphData graphData)
	{
		return null;
	}

	[Token(Token = "0x6005713")]
	[Address(RVA = "0x37A77A4", Offset = "0x37A77A4", VA = "0x37A77A4")]
	public BlockData CloneWithoutClearLocalVarCache(IBlockDataContainer parent, GraphData graphData)
	{
		return null;
	}

	[Token(Token = "0x6005714")]
	[Address(RVA = "0x37A6BB4", Offset = "0x37A6BB4", VA = "0x37A6BB4")]
	internal void CollectLocalVarDefineRecursively()
	{
	}

	[Token(Token = "0x6005715")]
	[Address(RVA = "0x37A71DC", Offset = "0x37A71DC", VA = "0x37A71DC")]
	internal BlockData InternalClone(IBlockDataContainer parent, GraphData graphData)
	{
		return null;
	}

	[Token(Token = "0x6005716")]
	[Address(RVA = "0x37A7FC4", Offset = "0x37A7FC4", VA = "0x37A7FC4")]
	public void RegisterLocalVar(GraphData graphData)
	{
	}

	[Token(Token = "0x6005717")]
	[Address(RVA = "0x37A8610", Offset = "0x37A8610", VA = "0x37A8610")]
	public void UnregisterLocalVar(GraphData graphData)
	{
	}

	[Token(Token = "0x6005718")]
	[Address(RVA = "0x37A0D8C", Offset = "0x37A0D8C", VA = "0x37A0D8C")]
	public bool InitByDefine()
	{
		return default(bool);
	}

	[Token(Token = "0x6005719")]
	public bool UpdateSelf<T>(UpdateType updateType, T param)
	{
		return default(bool);
	}

	[Token(Token = "0x600571A")]
	public void UpdateRecursively<T>(UpdateType updateType, T param)
	{
	}

	[Token(Token = "0x600571B")]
	public void UpdateSelfAndParent<T>(UpdateType updateType, T param)
	{
	}

	[Token(Token = "0x600571C")]
	[Address(RVA = "0x37A8EC0", Offset = "0x37A8EC0", VA = "0x37A8EC0")]
	public void UpdateCount()
	{
	}

	[Token(Token = "0x600571D")]
	[Address(RVA = "0x37A1268", Offset = "0x37A1268", VA = "0x37A1268")]
	public void UpdateForValuesChanged()
	{
	}

	[Token(Token = "0x600571E")]
	[Address(RVA = "0x37A96E8", Offset = "0x37A96E8", VA = "0x37A96E8")]
	public bool CheckLegality(BlockEditContext context)
	{
		return default(bool);
	}

	[Token(Token = "0x600571F")]
	[Address(RVA = "0x37ABB0C", Offset = "0x37ABB0C", VA = "0x37ABB0C")]
	public bool CheckLocalVarInDefineRange(string defineId, bool isParent, bool avoidCheckingBrother = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005720")]
	[Address(RVA = "0x37AC350", Offset = "0x37AC350", VA = "0x37AC350")]
	public int GetSectionSplicingCount()
	{
		return default(int);
	}

	[Token(Token = "0x6005721")]
	[Address(RVA = "0x37A8F7C", Offset = "0x37A8F7C", VA = "0x37A8F7C")]
	private void UpdateGraphPropertyGetter(GraphData targetGraph, ValueData valueParent)
	{
	}

	[Token(Token = "0x6005722")]
	[Address(RVA = "0x37A9110", Offset = "0x37A9110", VA = "0x37A9110")]
	private void UpdateGraphPropertySetter(GraphData targetGraph)
	{
	}

	[Token(Token = "0x6005723")]
	[Address(RVA = "0x37AC6CC", Offset = "0x37AC6CC", VA = "0x37AC6CC")]
	public BlockData GetRootParent()
	{
		return null;
	}

	[Token(Token = "0x6005724")]
	[Address(RVA = "0x37AC9F8", Offset = "0x37AC9F8", VA = "0x37AC9F8")]
	private bool CheckFuncReturnLegality(BlockData blockData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005725")]
	[Address(RVA = "0x37ACBE8", Offset = "0x37ACBE8", VA = "0x37ACBE8")]
	private bool CheckFuncReturnVoidLegality(BlockData blockData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005726")]
	[Address(RVA = "0x37ACDD8", Offset = "0x37ACDD8", VA = "0x37ACDD8")]
	private static int _003CToExportProtoData_003Em__0(ValueData item)
	{
		return default(int);
	}
}
