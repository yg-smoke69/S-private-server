using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AK.Wwise;

[Serializable]
[Token(Token = "0x2003E02")]
public class Switch : BaseGroupType
{
	[Token(Token = "0x401A481")]
	[FieldOffset(Offset = "0x18")]
	public WwiseSwitchReference WwiseObjectReference;

	[Token(Token = "0x17001B71")]
	public override WwiseObjectReference ObjectReference
	{
		[Token(Token = "0x60193A9")]
		[Address(RVA = "0x35BDB40", Offset = "0x35BDB40", VA = "0x35BDB40", Slot = "4")]
		get
		{
			return null;
		}
		[Token(Token = "0x60193AA")]
		[Address(RVA = "0x35BDB48", Offset = "0x35BDB48", VA = "0x35BDB48", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x17001B72")]
	public override WwiseObjectType WwiseObjectType
	{
		[Token(Token = "0x60193AB")]
		[Address(RVA = "0x35BDBE4", Offset = "0x35BDBE4", VA = "0x35BDBE4", Slot = "6")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x17001B73")]
	public override WwiseObjectType WwiseObjectGroupType
	{
		[Token(Token = "0x60193AC")]
		[Address(RVA = "0x35BDBEC", Offset = "0x35BDBEC", VA = "0x35BDBEC", Slot = "9")]
		get
		{
			return default(WwiseObjectType);
		}
	}

	[Token(Token = "0x60193A8")]
	[Address(RVA = "0x35BDB38", Offset = "0x35BDB38", VA = "0x35BDB38")]
	public Switch()
	{
	}

	[Token(Token = "0x60193AD")]
	[Address(RVA = "0x35BDBF4", Offset = "0x35BDBF4", VA = "0x35BDBF4")]
	public void SetValue(GameObject gameObject)
	{
	}
}
