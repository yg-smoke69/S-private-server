using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B83")]
public class BlockEditGraphs
{
	[Token(Token = "0x2000B84")]
	private sealed class _003CRemoveGraph_003Ec__AnonStorey0
	{
		[Token(Token = "0x4006187")]
		[FieldOffset(Offset = "0x8")]
		internal string graphId;

		[Token(Token = "0x600576D")]
		[Address(RVA = "0x37B0C24", Offset = "0x37B0C24", VA = "0x37B0C24")]
		public _003CRemoveGraph_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600576E")]
		[Address(RVA = "0x37B1C6C", Offset = "0x37B1C6C", VA = "0x37B1C6C")]
		internal bool _003C_003Em__0(GraphData graphData)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000B85")]
	private sealed class _003CFindGraphVar_003Ec__AnonStorey1
	{
		[Token(Token = "0x4006188")]
		[FieldOffset(Offset = "0x8")]
		internal string id;

		[Token(Token = "0x600576F")]
		[Address(RVA = "0x37B1A68", Offset = "0x37B1A68", VA = "0x37B1A68")]
		public _003CFindGraphVar_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6005770")]
		[Address(RVA = "0x37B1BD8", Offset = "0x37B1BD8", VA = "0x37B1BD8")]
		internal bool _003C_003Em__0(GraphData item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4006183")]
	[FieldOffset(Offset = "0x8")]
	private BlockEditContext _003CContext_003Ek__BackingField;

	[Token(Token = "0x4006184")]
	[FieldOffset(Offset = "0xC")]
	public List<GraphData> Graphs;

	[Token(Token = "0x4006185")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<string, GraphData> GraphDictionary;

	[Token(Token = "0x4006186")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<GraphData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170006FC")]
	public BlockEditContext Context
	{
		[Token(Token = "0x600575A")]
		[Address(RVA = "0x37AFE60", Offset = "0x37AFE60", VA = "0x37AFE60")]
		get
		{
			return null;
		}
		[Token(Token = "0x600575B")]
		[Address(RVA = "0x37AFE58", Offset = "0x37AFE58", VA = "0x37AFE58")]
		private set
		{
		}
	}

	[Token(Token = "0x6005759")]
	[Address(RVA = "0x37AFD90", Offset = "0x37AFD90", VA = "0x37AFD90")]
	public BlockEditGraphs(BlockEditContext context)
	{
	}

	[Token(Token = "0x600575C")]
	[Address(RVA = "0x37AFE68", Offset = "0x37AFE68", VA = "0x37AFE68")]
	public void Clear()
	{
	}

	[Token(Token = "0x600575D")]
	[Address(RVA = "0x37AFF54", Offset = "0x37AFF54", VA = "0x37AFF54")]
	public bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x600575E")]
	[Address(RVA = "0x37B01C4", Offset = "0x37B01C4", VA = "0x37B01C4")]
	public bool ToJsonData(BlockEditContext context, JsonWriter jsonWriter)
	{
		return default(bool);
	}

	[Token(Token = "0x600575F")]
	[Address(RVA = "0x37B03F4", Offset = "0x37B03F4", VA = "0x37B03F4")]
	public void ToExportProtoData(BlockEditContext context, List<JGIADJOKNHI> protoSource)
	{
	}

	[Token(Token = "0x6005760")]
	[Address(RVA = "0x37B0608", Offset = "0x37B0608", VA = "0x37B0608")]
	public GraphData CreateGraph(string entityId, FONLAPPBCOO type)
	{
		return null;
	}

	[Token(Token = "0x6005761")]
	[Address(RVA = "0x37B0798", Offset = "0x37B0798", VA = "0x37B0798")]
	public GraphData CreateGraph(FONLAPPBCOO type)
	{
		return null;
	}

	[Token(Token = "0x6005762")]
	[Address(RVA = "0x37B0920", Offset = "0x37B0920", VA = "0x37B0920")]
	public void AddGraph(GraphData graph)
	{
	}

	[Token(Token = "0x6005763")]
	[Address(RVA = "0x37B0A34", Offset = "0x37B0A34", VA = "0x37B0A34")]
	public void RemoveGraph(string graphId)
	{
	}

	[Token(Token = "0x6005764")]
	public void UpdateRecursively<T>(UpdateType updateType, T param)
	{
	}

	[Token(Token = "0x6005765")]
	[Address(RVA = "0x37B0C2C", Offset = "0x37B0C2C", VA = "0x37B0C2C")]
	public void CollectCustomString(EditorMiscData miscData)
	{
	}

	[Token(Token = "0x6005766")]
	[Address(RVA = "0x37B0DC8", Offset = "0x37B0DC8", VA = "0x37B0DC8")]
	public bool CheckLegality()
	{
		return default(bool);
	}

	[Token(Token = "0x6005767")]
	[Address(RVA = "0x37B156C", Offset = "0x37B156C", VA = "0x37B156C")]
	public void UpdateAfterBuilt()
	{
	}

	[Token(Token = "0x6005768")]
	[Address(RVA = "0x37A93F4", Offset = "0x37A93F4", VA = "0x37A93F4")]
	public GraphData FindGlobalGraph()
	{
		return null;
	}

	[Token(Token = "0x6005769")]
	[Address(RVA = "0x37B18C4", Offset = "0x37B18C4", VA = "0x37B18C4")]
	public GraphVarDefineData FindGraphVar(string id)
	{
		return null;
	}

	[Token(Token = "0x600576A")]
	[Address(RVA = "0x37B1A70", Offset = "0x37B1A70", VA = "0x37B1A70")]
	public GraphVarDefineData FindGraphVar(string graphId, string id)
	{
		return null;
	}

	[Token(Token = "0x600576B")]
	[Address(RVA = "0x37A95AC", Offset = "0x37A95AC", VA = "0x37A95AC")]
	public FuncDefineData FindFunc(string graphId, string id)
	{
		return null;
	}

	[Token(Token = "0x600576C")]
	[Address(RVA = "0x37B1BAC", Offset = "0x37B1BAC", VA = "0x37B1BAC")]
	private static bool _003CFindGlobalGraph_003Em__0(GraphData item)
	{
		return default(bool);
	}
}
