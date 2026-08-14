using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace AK.Wwise;

[Serializable]
[Token(Token = "0x2003DFB")]
public class Bank : BaseType
{
	[Token(Token = "0x401A478")]
	[FieldOffset(Offset = "0x10")]
	public WwiseBankReference WwiseObjectReference;

	[Token(Token = "0x17001B5D")]
	public override WwiseObjectReference ObjectReference
	{
		[Token(Token = "0x6019372")]
		[Address(RVA = "0x35BBF04", Offset = "0x35BBF04", VA = "0x35BBF04", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019373")]
		[Address(RVA = "0x35BBF0C", Offset = "0x35BBF0C", VA = "0x35BBF0C", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17001B5E")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x6019374")]
		[Address(RVA = "0x35BBFA8", Offset = "0x35BBFA8", VA = "0x35BBFA8", Slot = "6")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x6019371")]
	[Address(RVA = "0x35BBEFC", Offset = "0x35BBEFC", VA = "0x35BBEFC")]
	public Bank()
	{
	}

	[Token(Token = "0x6019375")]
	[Address(RVA = "0x35BBFB0", Offset = "0x35BBFB0", VA = "0x35BBFB0")]
	public void Load(bool decodeBank = false, bool saveDecodedBank = false)
	{
	}

	[Token(Token = "0x6019376")]
	[Address(RVA = "0x35BC33C", Offset = "0x35BC33C", VA = "0x35BC33C")]
	public void LoadAsync([Optional] AkCallbackManager.BankCallback callback)
	{
	}

	[Token(Token = "0x6019377")]
	[Address(RVA = "0x35BC684", Offset = "0x35BC684", VA = "0x35BC684")]
	public void Unload()
	{
	}
}
