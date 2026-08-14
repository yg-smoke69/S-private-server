using System;
using System.Collections.Generic;
using ECAPackage;
using Il2CppDummyDll;
using XNode;
using message;

[Token(Token = "0x20002CD")]
public class ECAWorkflow : NodeGraph
{
	[Token(Token = "0x20002CE")]
	private sealed class _003CNodeCount_003Ec__AnonStorey0
	{
		[Token(Token = "0x4003305")]
		[FieldOffset(Offset = "0x8")]
		internal Type t;

		[Token(Token = "0x6000D8B")]
		[Address(RVA = "0x32052A4", Offset = "0x32052A4", VA = "0x32052A4")]
		public _003CNodeCount_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000D8C")]
		[Address(RVA = "0x3206824", Offset = "0x3206824", VA = "0x3206824")]
		internal bool _003C_003Em__0(Node n)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4003301")]
	[FieldOffset(Offset = "0x10")]
	public HashSet<uint> m_usedIndex;

	[Token(Token = "0x4003302")]
	[FieldOffset(Offset = "0x14")]
	public List<ECAAsset> GraphAsset;

	[Token(Token = "0x4003303")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<Node> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4003304")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<Node> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6000D82")]
	[Address(RVA = "0x3204E10", Offset = "0x3204E10", VA = "0x3204E10")]
	public ECAWorkflow()
	{
	}

	[Token(Token = "0x6000D83")]
	[Address(RVA = "0x3204ED0", Offset = "0x3204ED0", VA = "0x3204ED0")]
	public void ResetUsedIndex()
	{
	}

	[Token(Token = "0x6000D84")]
	[Address(RVA = "0x3205180", Offset = "0x3205180", VA = "0x3205180")]
	public int NodeCount(Type t)
	{
		return default(int);
	}

	[Token(Token = "0x6000D85")]
	[Address(RVA = "0x3203BEC", Offset = "0x3203BEC", VA = "0x3203BEC")]
	public uint GetUnusedIndex()
	{
		return default(uint);
	}

	[Token(Token = "0x6000D86")]
	[Address(RVA = "0x32042A4", Offset = "0x32042A4", VA = "0x32042A4")]
	public void ReleaseUsedIndex(uint removeIndex)
	{
	}

	[Token(Token = "0x6000D87")]
	[Address(RVA = "0x32052AC", Offset = "0x32052AC", VA = "0x32052AC")]
	public bool CheckWorkflowValid()
	{
		return default(bool);
	}

	[Token(Token = "0x6000D88")]
	[Address(RVA = "0x3205C14", Offset = "0x3205C14", VA = "0x3205C14")]
	public HMHKAANAOPE GetWorkflowConfig()
	{
		return null;
	}

	[Token(Token = "0x6000D89")]
	[Address(RVA = "0x3206684", Offset = "0x3206684", VA = "0x3206684")]
	private static bool _003CCheckWorkflowValid_003Em__0(Node n)
	{
		return default(bool);
	}

	[Token(Token = "0x6000D8A")]
	[Address(RVA = "0x3206754", Offset = "0x3206754", VA = "0x3206754")]
	private static bool _003CGetWorkflowConfig_003Em__1(Node n)
	{
		return default(bool);
	}
}
