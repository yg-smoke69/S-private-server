using System;
using System.Runtime.InteropServices;
using IFix.Core;
using Il2CppDummyDll;

namespace IFix;

[Token(Token = "0x20041B7")]
public class WrappersManagerImpl : _Attribute
{
	[Token(Token = "0x401B8D7")]
	[FieldOffset(Offset = "0x8")]
	private VirtualMachine virtualMachine;

	[Token(Token = "0x601C341")]
	[Address(RVA = "0x310650C", Offset = "0x310650C", VA = "0x310650C")]
	public WrappersManagerImpl(VirtualMachine virtualMachine)
	{
	}

	[Token(Token = "0x601C342")]
	[Address(RVA = "0x310652C", Offset = "0x310652C", VA = "0x310652C")]
	public static ILFixDynamicMethodWrapper GetPatch(int id)
	{
		return null;
	}

	[Token(Token = "0x601C343")]
	[Address(RVA = "0x31065F0", Offset = "0x31065F0", VA = "0x31065F0")]
	public static bool IsPatched(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x601C344")]
	[Address(RVA = "0x3106720", Offset = "0x3106720", VA = "0x3106720", Slot = "4")]
	public Delegate CreateDelegate(Type type, int id, object anon)
	{
		return null;
	}

	[Token(Token = "0x601C345")]
	[Address(RVA = "0x3106804", Offset = "0x3106804", VA = "0x3106804", Slot = "6")]
	public object CreateWrapper(int id)
	{
		return null;
	}

	[Token(Token = "0x601C346")]
	[Address(RVA = "0x3106898", Offset = "0x3106898", VA = "0x3106898", Slot = "7")]
	public object InitWrapperArray(int len)
	{
		return null;
	}

	[Token(Token = "0x601C347")]
	[Address(RVA = "0x310695C", Offset = "0x310695C", VA = "0x310695C", Slot = "5")]
	public AnonymousStorey CreateBridge(int fieldNum, int[] fieldTypes, int typeIndex, int[] vTable, int[] slots, VirtualMachine virtualMachine)
	{
		return null;
	}
}
