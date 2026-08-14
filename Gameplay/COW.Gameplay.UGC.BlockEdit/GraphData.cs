using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon.CommandPattern;
using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B86")]
public class GraphData : _Attribute
{
	[Token(Token = "0x2000B87")]
	private sealed class _003CGetHudEventBlockInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x400619C")]
		[FieldOffset(Offset = "0x8")]
		internal int widgetId;

		[Token(Token = "0x6005796")]
		[Address(RVA = "0x2F473A8", Offset = "0x2F473A8", VA = "0x2F473A8")]
		public _003CGetHudEventBlockInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6005797")]
		[Address(RVA = "0x2F48D30", Offset = "0x2F48D30", VA = "0x2F48D30")]
		internal bool _003C_003Em__0(UGCHudEventBlockInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4006189")]
	[FieldOffset(Offset = "0x8")]
	public string id;

	[Token(Token = "0x400618A")]
	[FieldOffset(Offset = "0xC")]
	private bool mIsDeleted;

	[Token(Token = "0x400618B")]
	[FieldOffset(Offset = "0x10")]
	public string EntityID;

	[Token(Token = "0x400618C")]
	[FieldOffset(Offset = "0x14")]
	public FONLAPPBCOO EntityType;

	[Token(Token = "0x400618D")]
	[FieldOffset(Offset = "0x18")]
	public CanvasData Canvas;

	[Token(Token = "0x400618E")]
	[FieldOffset(Offset = "0x1C")]
	public List<BlockData> RootBlockDataList;

	[Token(Token = "0x400618F")]
	[FieldOffset(Offset = "0x20")]
	public Dictionary<string, GraphVarDefineData> GraphVarDefines;

	[Token(Token = "0x4006190")]
	[FieldOffset(Offset = "0x24")]
	public List<GraphVarDefineData> GraphVarDefinesList;

	[Token(Token = "0x4006191")]
	[FieldOffset(Offset = "0x28")]
	private BlockEditContext _003CContext_003Ek__BackingField;

	[Token(Token = "0x4006192")]
	[FieldOffset(Offset = "0x2C")]
	private CommandFactory CommandFactory;

	[Token(Token = "0x4006193")]
	[FieldOffset(Offset = "0x30")]
	public CommandManager CommandManager;

	[Token(Token = "0x4006194")]
	[FieldOffset(Offset = "0x34")]
	public Dictionary<string, LocalVarDefineData> LocalVarDefines;

	[Token(Token = "0x4006195")]
	[FieldOffset(Offset = "0x38")]
	public Dictionary<string, BlockData> AllBlockDatas;

	[Token(Token = "0x4006196")]
	[FieldOffset(Offset = "0x3C")]
	public Dictionary<string, FuncDefineData> FuncDefines;

	[Token(Token = "0x4006197")]
	[FieldOffset(Offset = "0x40")]
	public Action<GraphData> OnLocalVarDefinesReady;

	[Token(Token = "0x4006198")]
	[FieldOffset(Offset = "0x44")]
	public bool CheckLegalityPassed;

	[Token(Token = "0x4006199")]
	[FieldOffset(Offset = "0x48")]
	private List<UGCHudEventBlockInfo> m_UGCHudEventInfoList;

	[Token(Token = "0x400619A")]
	[FieldOffset(Offset = "0x4C")]
	public bool NeedToUpdate;

	[Token(Token = "0x400619B")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<GraphVarDefineData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170006FD")]
	public bool IsDeleted
	{
		[Token(Token = "0x6005772")]
		[Address(RVA = "0x2F43D2C", Offset = "0x2F43D2C", VA = "0x2F43D2C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005773")]
		[Address(RVA = "0x2F43E0C", Offset = "0x2F43E0C", VA = "0x2F43E0C")]
		set
		{
		}
	}

	[Token(Token = "0x170006FE")]
	public BlockEditContext Context
	{
		[Token(Token = "0x6005774")]
		[Address(RVA = "0x2F43E6C", Offset = "0x2F43E6C", VA = "0x2F43E6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005775")]
		[Address(RVA = "0x2F43D24", Offset = "0x2F43D24", VA = "0x2F43D24")]
		private set
		{
		}
	}

	[Token(Token = "0x170006FF")]
	public List<UGCHudEventBlockInfo> UGCHudEventInfoList
	{
		[Token(Token = "0x6005776")]
		[Address(RVA = "0x2F43E74", Offset = "0x2F43E74", VA = "0x2F43E74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005771")]
	[Address(RVA = "0x2F43AD0", Offset = "0x2F43AD0", VA = "0x2F43AD0")]
	internal GraphData(BlockEditContext context)
	{
	}

	[Token(Token = "0x6005777")]
	[Address(RVA = "0x2F43ECC", Offset = "0x2F43ECC", VA = "0x2F43ECC")]
	public void UpdateGraphData()
	{
	}

	[Token(Token = "0x6005778")]
	[Address(RVA = "0x2F44008", Offset = "0x2F44008", VA = "0x2F44008")]
	public bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005779")]
	[Address(RVA = "0x2F449FC", Offset = "0x2F449FC", VA = "0x2F449FC")]
	public bool ToJsonData(BlockEditContext context, JsonWriter jsonWriter)
	{
		return default(bool);
	}

	[Token(Token = "0x600577A")]
	[Address(RVA = "0x2F44F60", Offset = "0x2F44F60", VA = "0x2F44F60")]
	public JGIADJOKNHI ToExportProtoData(BlockEditContext context)
	{
		return null;
	}

	[Token(Token = "0x600577B")]
	[Address(RVA = "0x2F45830", Offset = "0x2F45830", VA = "0x2F45830")]
	public bool RegisterLocalVar(LocalVarDefineData varDefineData)
	{
		return default(bool);
	}

	[Token(Token = "0x600577C")]
	[Address(RVA = "0x2F45954", Offset = "0x2F45954", VA = "0x2F45954")]
	public bool UnregisterLocalVar(string varId)
	{
		return default(bool);
	}

	[Token(Token = "0x600577D")]
	[Address(RVA = "0x2F45B00", Offset = "0x2F45B00", VA = "0x2F45B00")]
	public void RegisterLocalVar(VarRecord varRecord)
	{
	}

	[Token(Token = "0x600577E")]
	[Address(RVA = "0x2F45C84", Offset = "0x2F45C84", VA = "0x2F45C84")]
	public void UnregisterLocalVar(VarRecord varRecord)
	{
	}

	[Token(Token = "0x600577F")]
	[Address(RVA = "0x2F45DE8", Offset = "0x2F45DE8", VA = "0x2F45DE8")]
	public bool AddGraphVar(GraphVarDefineData graphVarDefineData, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x6005780")]
	[Address(RVA = "0x2F46104", Offset = "0x2F46104", VA = "0x2F46104")]
	public void RemoveGraphVar(string id)
	{
	}

	[Token(Token = "0x6005781")]
	[Address(RVA = "0x2F46274", Offset = "0x2F46274", VA = "0x2F46274")]
	public bool AddGraphVar(GraphVarRecord record)
	{
		return default(bool);
	}

	[Token(Token = "0x6005782")]
	[Address(RVA = "0x2F46438", Offset = "0x2F46438", VA = "0x2F46438")]
	public void RemoveGraphVar(GraphVarRecord record)
	{
	}

	[Token(Token = "0x6005783")]
	[Address(RVA = "0x2F465E4", Offset = "0x2F465E4", VA = "0x2F465E4")]
	public bool RegisterFunc(FuncDefineData funcDefineData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005784")]
	[Address(RVA = "0x2F46708", Offset = "0x2F46708", VA = "0x2F46708")]
	public bool UnregisterFunc(string funcId)
	{
		return default(bool);
	}

	[Token(Token = "0x6005785")]
	[Address(RVA = "0x2F468B4", Offset = "0x2F468B4", VA = "0x2F468B4")]
	public FuncDefineData CreateFunc(string funcName, TypeInfo returnType, List<string> paramNames, List<TypeInfo> paramTypes, out BlockData definerData)
	{
		return null;
	}

	[Token(Token = "0x6005786")]
	[Address(RVA = "0x2F47240", Offset = "0x2F47240", VA = "0x2F47240")]
	public UGCHudEventBlockInfo GetHudEventBlockInfo(int widgetId)
	{
		return null;
	}

	[Token(Token = "0x6005787")]
	public T CreateCommand<T>() where T : Command, new()
	{
		return null;
	}

	[Token(Token = "0x6005788")]
	public void ReleaseCommand<T>(T command) where T : Command, new()
	{
	}

	[Token(Token = "0x6005789")]
	[Address(RVA = "0x2F473B0", Offset = "0x2F473B0", VA = "0x2F473B0", Slot = "4")]
	public BlockData GetOwner()
	{
		return null;
	}

	[Token(Token = "0x600578A")]
	[Address(RVA = "0x2F47408", Offset = "0x2F47408", VA = "0x2F47408", Slot = "5")]
	public BlockData GetChild(int index)
	{
		return null;
	}

	[Token(Token = "0x600578B")]
	[Address(RVA = "0x2F4751C", Offset = "0x2F4751C", VA = "0x2F4751C", Slot = "6")]
	public int GetChildIndex(BlockData blockData)
	{
		return default(int);
	}

	[Token(Token = "0x600578C")]
	[Address(RVA = "0x2F475E8", Offset = "0x2F475E8", VA = "0x2F475E8", Slot = "7")]
	public bool AddBlockData(BlockData blockData, int index, bool doRegistering = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600578D")]
	[Address(RVA = "0x2F4788C", Offset = "0x2F4788C", VA = "0x2F4788C", Slot = "8")]
	public bool RemoveBlockData(BlockData blockData, bool doUnregistering = true)
	{
		return default(bool);
	}

	[Token(Token = "0x600578E")]
	[Address(RVA = "0x2F47B38", Offset = "0x2F47B38", VA = "0x2F47B38", Slot = "9")]
	public bool AddBlockData(BlockRecord record)
	{
		return default(bool);
	}

	[Token(Token = "0x600578F")]
	[Address(RVA = "0x2F47E7C", Offset = "0x2F47E7C", VA = "0x2F47E7C", Slot = "10")]
	public bool RemoveBlockData(BlockRecord record)
	{
		return default(bool);
	}

	[Token(Token = "0x6005790")]
	[Address(RVA = "0x2F45F60", Offset = "0x2F45F60", VA = "0x2F45F60")]
	public void RefreshGraphVarDefinesIndex()
	{
	}

	[Token(Token = "0x6005791")]
	public void UpdateRecursively<T>(UpdateType updateType, T param)
	{
	}

	[Token(Token = "0x6005792")]
	[Address(RVA = "0x2F480BC", Offset = "0x2F480BC", VA = "0x2F480BC")]
	public void CollectCustomString(EditorMiscData miscData)
	{
	}

	[Token(Token = "0x6005793")]
	[Address(RVA = "0x2F488AC", Offset = "0x2F488AC", VA = "0x2F488AC")]
	public bool CheckLegality()
	{
		return default(bool);
	}

	[Token(Token = "0x6005794")]
	[Address(RVA = "0x2F48B78", Offset = "0x2F48B78", VA = "0x2F48B78")]
	public void Clear()
	{
	}

	[Token(Token = "0x6005795")]
	[Address(RVA = "0x2F48CE8", Offset = "0x2F48CE8", VA = "0x2F48CE8")]
	private static int _003CFromJsonData_003Em__0(GraphVarDefineData x, GraphVarDefineData y)
	{
		return default(int);
	}
}
