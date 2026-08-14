using System;
using System.Runtime.InteropServices;
using IFix.Core;
using Il2CppDummyDll;

namespace IFix;

[Token(Token = "0x20041B6")]
public class ILFixInterfaceBridge : AnonymousStorey, _Attribute, IConvertible, IComparable<int>
{
	[Token(Token = "0x401B8D2")]
	[FieldOffset(Offset = "0x28")]
	private int methodId_0;

	[Token(Token = "0x401B8D3")]
	[FieldOffset(Offset = "0x2C")]
	private int methodId_1;

	[Token(Token = "0x401B8D4")]
	[FieldOffset(Offset = "0x30")]
	private int methodId_2;

	[Token(Token = "0x401B8D5")]
	[FieldOffset(Offset = "0x34")]
	private int methodId_3;

	[Token(Token = "0x401B8D6")]
	[FieldOffset(Offset = "0x38")]
	private int methodId_4;

	[Token(Token = "0x17001D8B")]
	private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
	{
		[Token(Token = "0x601C33B")]
		[Address(RVA = "0x3106064", Offset = "0x3106064", VA = "0x3106064", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D8C")]
	private object System_002ECollections_002EIEnumerator_002ECurrent
	{
		[Token(Token = "0x601C33C")]
		[Address(RVA = "0x3106154", Offset = "0x3106154", VA = "0x3106154", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601C33A")]
	[Address(RVA = "0x3105FBC", Offset = "0x3105FBC", VA = "0x3105FBC", Slot = "5")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Token(Token = "0x601C33D")]
	[Address(RVA = "0x3106244", Offset = "0x3106244", VA = "0x3106244", Slot = "8")]
	public void Dispose()
	{
	}

	[Token(Token = "0x601C33E")]
	[Address(RVA = "0x31062D8", Offset = "0x31062D8", VA = "0x31062D8", Slot = "6")]
	public void Reset()
	{
	}

	[Token(Token = "0x601C33F")]
	[Address(RVA = "0x310636C", Offset = "0x310636C", VA = "0x310636C")]
	public ILFixInterfaceBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] methodIdArray, VirtualMachine virtualMachine)
	{
	}

	[Token(Token = "0x601C340")]
	[Address(RVA = "0x3106508", Offset = "0x3106508", VA = "0x3106508")]
	public void RefAsyncBuilderStartMethod()
	{
	}
}
