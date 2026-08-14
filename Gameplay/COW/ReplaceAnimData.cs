using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001FD2")]
public class ReplaceAnimData
{
	[Token(Token = "0x400C7AA")]
	[FieldOffset(Offset = "0x8")]
	public bool Enabled;

	[Token(Token = "0x400C7AB")]
	[FieldOffset(Offset = "0x9")]
	public bool Replaced;

	[Token(Token = "0x400C7AC")]
	[FieldOffset(Offset = "0xA")]
	public bool Dirty;

	[Token(Token = "0x400C7AD")]
	[FieldOffset(Offset = "0xC")]
	public AnimationClip DefaultAnim;

	[Token(Token = "0x400C7AE")]
	[FieldOffset(Offset = "0x10")]
	public ResourceID OverrideAnimID;

	[Token(Token = "0x400C7AF")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID EffectID;

	[Token(Token = "0x400C7B0")]
	[FieldOffset(Offset = "0x18")]
	public string OverrideSlotName;

	[Token(Token = "0x17000FB2")]
	public bool HasOverrideAnim
	{
		[Token(Token = "0x6009F6D")]
		[Address(RVA = "0x197BFC8", Offset = "0x197BFC8", VA = "0x197BFC8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000FB3")]
	public bool EnableAndReplaced
	{
		[Token(Token = "0x6009F74")]
		[Address(RVA = "0x197C480", Offset = "0x197C480", VA = "0x197C480")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6009F6C")]
	[Address(RVA = "0x197BF1C", Offset = "0x197BF1C", VA = "0x197BF1C")]
	public ReplaceAnimData()
	{
	}

	[Token(Token = "0x6009F6E")]
	[Address(RVA = "0x197C0B0", Offset = "0x197C0B0", VA = "0x197C0B0")]
	public void ResetDefaultAnim()
	{
	}

	[Token(Token = "0x6009F6F")]
	[Address(RVA = "0x197C12C", Offset = "0x197C12C", VA = "0x197C12C")]
	public void ResetOverrideAnim()
	{
	}

	[Token(Token = "0x6009F70")]
	[Address(RVA = "0x197C294", Offset = "0x197C294", VA = "0x197C294")]
	public void SetOverrideAnim(string slot, ResourceID id)
	{
	}

	[Token(Token = "0x6009F71")]
	[Address(RVA = "0x197C31C", Offset = "0x197C31C", VA = "0x197C31C")]
	public void SetOverrideAnim(ResourceID id)
	{
	}

	[Token(Token = "0x6009F72")]
	[Address(RVA = "0x197C388", Offset = "0x197C388", VA = "0x197C388")]
	public void SetEffect(ResourceID id)
	{
	}

	[Token(Token = "0x6009F73")]
	[Address(RVA = "0x197C3F4", Offset = "0x197C3F4", VA = "0x197C3F4")]
	public void SetEnabled(bool b)
	{
	}
}
