using System;
using Il2CppDummyDll;

namespace AK.Wwise;

[Serializable]
[Token(Token = "0x2003DFC")]
public abstract class BaseGroupType : BaseType
{
	[Token(Token = "0x401A479")]
	[FieldOffset(Offset = "0x10")]
	private int groupIdInternal;

	[Token(Token = "0x401A47A")]
	[FieldOffset(Offset = "0x14")]
	private byte[] groupGuidInternal;

	[Token(Token = "0x17001B5F")]
	public WwiseObjectReference GroupWwiseObjectReference
	{
		[Token(Token = "0x6019379")]
		[Address(RVA = "0x35BC968", Offset = "0x35BC968", VA = "0x35BC968")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B60")]
	public abstract WwiseObjectType WwiseObjectGroupType
	{
		[Token(Token = "0x601937A")]
		get;
	}

	[Token(Token = "0x17001B61")]
	public uint GroupId
	{
		[Token(Token = "0x601937B")]
		[Address(RVA = "0x35BCA4C", Offset = "0x35BCA4C", VA = "0x35BCA4C")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001B62")]
	public int groupID
	{
		[Token(Token = "0x601937D")]
		[Address(RVA = "0x35BCB04", Offset = "0x35BCB04", VA = "0x35BCB04")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001B63")]
	public byte[] groupGuid
	{
		[Token(Token = "0x601937E")]
		[Address(RVA = "0x35BCB08", Offset = "0x35BCB08", VA = "0x35BCB08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019378")]
	[Address(RVA = "0x35BC960", Offset = "0x35BC960", VA = "0x35BC960")]
	protected BaseGroupType()
	{
	}

	[Token(Token = "0x601937C")]
	[Address(RVA = "0x35BCA9C", Offset = "0x35BCA9C", VA = "0x35BCA9C", Slot = "8")]
	public override bool IsValid()
	{
		return default(bool);
	}
}
