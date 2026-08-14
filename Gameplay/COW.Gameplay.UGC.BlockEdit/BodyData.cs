using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using LitJson;
using message;

namespace COW.Gameplay.UGC.BlockEdit;

[Token(Token = "0x2000B7F")]
public class BodyData : _Attribute
{
	[Token(Token = "0x4006166")]
	[FieldOffset(Offset = "0x8")]
	public List<BlockData> actions;

	[Token(Token = "0x4006167")]
	[FieldOffset(Offset = "0xC")]
	public List<ValueData> values;

	[Token(Token = "0x4006168")]
	[FieldOffset(Offset = "0x10")]
	public ProcessBlockBodyDefine BodyDefine;

	[Token(Token = "0x4006169")]
	[FieldOffset(Offset = "0x14")]
	public BlockData Owner;

	[Token(Token = "0x400616A")]
	[FieldOffset(Offset = "0x18")]
	public GraphData Graph;

	[Token(Token = "0x400616B")]
	[FieldOffset(Offset = "0x1C")]
	public object UserRef;

	[Token(Token = "0x400616C")]
	[FieldOffset(Offset = "0x0")]
	private static Func<BlockEditContext, JsonWriter, BlockData, bool> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x400616D")]
	[FieldOffset(Offset = "0x4")]
	private static Func<BlockEditContext, JsonWriter, ValueData, bool> _003C_003Ef__mg_0024cache1;

	[Token(Token = "0x400616E")]
	[FieldOffset(Offset = "0x8")]
	private static Func<ValueData, int> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600572F")]
	[Address(RVA = "0x37A8B84", Offset = "0x37A8B84", VA = "0x37A8B84")]
	public BodyData()
	{
	}

	[Token(Token = "0x6005730")]
	[Address(RVA = "0x37A8C10", Offset = "0x37A8C10", VA = "0x37A8C10")]
	public bool InitByDefine()
	{
		return default(bool);
	}

	[Token(Token = "0x6005731")]
	[Address(RVA = "0x37BBF0C", Offset = "0x37BBF0C", VA = "0x37BBF0C", Slot = "11")]
	public virtual bool FromJsonData(BlockEditContext context, JsonData jsonData)
	{
		return default(bool);
	}

	[Token(Token = "0x6005732")]
	[Address(RVA = "0x37BC7A4", Offset = "0x37BC7A4", VA = "0x37BC7A4", Slot = "12")]
	public virtual bool ToJsonData(BlockEditContext context, JsonWriter jsonWriter)
	{
		return default(bool);
	}

	[Token(Token = "0x6005733")]
	[Address(RVA = "0x37A5AB0", Offset = "0x37A5AB0", VA = "0x37A5AB0")]
	public KDNPLMHKBHC ToExportProtoData(BlockEditContext context)
	{
		return null;
	}

	[Token(Token = "0x6005734")]
	[Address(RVA = "0x37A7834", Offset = "0x37A7834", VA = "0x37A7834")]
	internal void CollectLocalVarDefineRecursively()
	{
	}

	[Token(Token = "0x6005735")]
	[Address(RVA = "0x37A7B5C", Offset = "0x37A7B5C", VA = "0x37A7B5C")]
	internal BodyData Clone(BlockData owner, ProcessBlockBodyDefine bodyDefine, GraphData graphData)
	{
		return null;
	}

	[Token(Token = "0x6005736")]
	[Address(RVA = "0x37A83C8", Offset = "0x37A83C8", VA = "0x37A83C8")]
	public void RegisterLocalVar(GraphData graphData)
	{
	}

	[Token(Token = "0x6005737")]
	[Address(RVA = "0x37A8A4C", Offset = "0x37A8A4C", VA = "0x37A8A4C")]
	public void UnregisterLocalVar(GraphData graphData)
	{
	}

	[Token(Token = "0x6005738")]
	[Address(RVA = "0x37BCA50", Offset = "0x37BCA50", VA = "0x37BCA50", Slot = "4")]
	public BlockData GetOwner()
	{
		return null;
	}

	[Token(Token = "0x6005739")]
	[Address(RVA = "0x37BCAA8", Offset = "0x37BCAA8", VA = "0x37BCAA8", Slot = "5")]
	public BlockData GetChild(int index)
	{
		return null;
	}

	[Token(Token = "0x600573A")]
	[Address(RVA = "0x37B58C0", Offset = "0x37B58C0", VA = "0x37B58C0", Slot = "6")]
	public int GetChildIndex(BlockData blockData)
	{
		return default(int);
	}

	[Token(Token = "0x600573B")]
	[Address(RVA = "0x37B5988", Offset = "0x37B5988", VA = "0x37B5988", Slot = "7")]
	public bool AddBlockData(BlockData blockData, int index, bool doRegistering = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600573C")]
	[Address(RVA = "0x37BCBB0", Offset = "0x37BCBB0", VA = "0x37BCBB0", Slot = "8")]
	public bool RemoveBlockData(BlockData blockData, bool doUnregistering = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600573D")]
	[Address(RVA = "0x37BCCCC", Offset = "0x37BCCCC", VA = "0x37BCCCC")]
	public bool AddBlockDataList(List<BlockData> blockDataList, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x600573E")]
	[Address(RVA = "0x37BD09C", Offset = "0x37BD09C", VA = "0x37BD09C", Slot = "9")]
	public bool AddBlockData(BlockRecord record)
	{
		return default(bool);
	}

	[Token(Token = "0x600573F")]
	[Address(RVA = "0x37BD35C", Offset = "0x37BD35C", VA = "0x37BD35C", Slot = "10")]
	public bool RemoveBlockData(BlockRecord record)
	{
		return default(bool);
	}

	[Token(Token = "0x6005740")]
	[Address(RVA = "0x37BD500", Offset = "0x37BD500", VA = "0x37BD500")]
	public bool RemoveBlockDataRange(int from, int count)
	{
		return default(bool);
	}

	[Token(Token = "0x6005741")]
	public bool UpdateSelf<T>(UpdateType updateType, T param)
	{
		return default(bool);
	}

	[Token(Token = "0x6005742")]
	public void UpdateRecursively<T>(UpdateType updateType, T param)
	{
	}

	[Token(Token = "0x6005743")]
	public void UpdateSelfAndParent<T>(UpdateType updateType, T param)
	{
	}

	[Token(Token = "0x6005744")]
	[Address(RVA = "0x37BD6BC", Offset = "0x37BD6BC", VA = "0x37BD6BC")]
	private static int _003CToExportProtoData_003Em__0(ValueData item)
	{
		return default(int);
	}
}
