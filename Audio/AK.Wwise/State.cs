using System;
using Il2CppDummyDll;

namespace AK.Wwise;

[Serializable]
[Token(Token = "0x2003E01")]
public class State : BaseGroupType
{
	[Token(Token = "0x401A480")]
	[FieldOffset(Offset = "0x18")]
	public WwiseStateReference WwiseObjectReference;

	[Token(Token = "0x17001B6E")]
	public override WwiseObjectReference ObjectReference
	{
		[Token(Token = "0x60193A3")]
		[Address(RVA = "0x35BD9C8", Offset = "0x35BD9C8", VA = "0x35BD9C8", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60193A4")]
		[Address(RVA = "0x35BD9D0", Offset = "0x35BD9D0", VA = "0x35BD9D0", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17001B6F")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x60193A5")]
		[Address(RVA = "0x35BDA6C", Offset = "0x35BDA6C", VA = "0x35BDA6C", Slot = "6")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x17001B70")]
	public override WwiseObjectType WwiseObjectGroupType
	{
		[Token(Token = "0x60193A6")]
		[Address(RVA = "0x35BDA74", Offset = "0x35BDA74", VA = "0x35BDA74", Slot = "9")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x60193A2")]
	[Address(RVA = "0x35BD9C0", Offset = "0x35BD9C0", VA = "0x35BD9C0")]
	public State()
	{
	}

	[Token(Token = "0x60193A7")]
	[Address(RVA = "0x35BDA7C", Offset = "0x35BDA7C", VA = "0x35BDA7C")]
	public void SetValue()
	{
	}
}
