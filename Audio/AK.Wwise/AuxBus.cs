using System;
using Il2CppDummyDll;

namespace AK.Wwise;

[Serializable]
[Token(Token = "0x2003DFA")]
public class AuxBus : BaseType
{
	[Token(Token = "0x401A477")]
	[FieldOffset(Offset = "0x10")]
	public WwiseAuxBusReference WwiseObjectReference;

	[Token(Token = "0x17001B5B")]
	public override WwiseObjectReference ObjectReference
	{
		[Token(Token = "0x601936E")]
		[Address(RVA = "0x35BBE50", Offset = "0x35BBE50", VA = "0x35BBE50", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x601936F")]
		[Address(RVA = "0x35BBE58", Offset = "0x35BBE58", VA = "0x35BBE58", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17001B5C")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x6019370")]
		[Address(RVA = "0x35BBEF4", Offset = "0x35BBEF4", VA = "0x35BBEF4", Slot = "6")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x601936D")]
	[Address(RVA = "0x35BBE48", Offset = "0x35BBE48", VA = "0x35BBE48")]
	public AuxBus()
	{
	}
}
