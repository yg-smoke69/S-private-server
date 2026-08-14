using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2000443")]
public class BountyWaitingLocalPlayerCutscene : MonoBehaviour
{
	[Token(Token = "0x4003C29")]
	[FieldOffset(Offset = "0xC")]
	public int CutsceneIndex;

	[Token(Token = "0x4003C2A")]
	[FieldOffset(Offset = "0x10")]
	public string MaleAnimResID;

	[Token(Token = "0x4003C2B")]
	[FieldOffset(Offset = "0x14")]
	public string FemaleAnimResID;

	[Token(Token = "0x4003C2C")]
	[FieldOffset(Offset = "0x18")]
	private ResourceID m_ChooseID;

	[Token(Token = "0x4003C2D")]
	[FieldOffset(Offset = "0x1C")]
	private AnimationClip m_ChooseClip;

	[Token(Token = "0x170001DC")]
	public AnimationClip ChooseClip
	{
		[Token(Token = "0x6001554")]
		[Address(RVA = "0x14B3FA4", Offset = "0x14B3FA4", VA = "0x14B3FA4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001553")]
	[Address(RVA = "0x14B4750", Offset = "0x14B4750", VA = "0x14B4750")]
	public BountyWaitingLocalPlayerCutscene()
	{
	}

	[Token(Token = "0x6001555")]
	[Address(RVA = "0x14B271C", Offset = "0x14B271C", VA = "0x14B271C")]
	public void LoadAnimClip(bool isFemale)
	{
	}

	[Token(Token = "0x6001556")]
	[Address(RVA = "0x14B2C50", Offset = "0x14B2C50", VA = "0x14B2C50")]
	public void UnloadAnimClip()
	{
	}
}
