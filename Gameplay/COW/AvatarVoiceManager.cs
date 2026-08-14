using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E7A")]
public class AvatarVoiceManager : SingletonModule<AvatarVoiceManager>
{
	[Token(Token = "0x400BF9B")]
	[FieldOffset(Offset = "0xC")]
	private IAvatarVoice m_AvatarVoice;

	[Token(Token = "0x600929D")]
	[Address(RVA = "0x236283C", Offset = "0x236283C", VA = "0x236283C")]
	public AvatarVoiceManager()
	{
	}

	[Token(Token = "0x600929E")]
	[Address(RVA = "0x23628CC", Offset = "0x23628CC", VA = "0x23628CC", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x600929F")]
	[Address(RVA = "0x2362984", Offset = "0x2362984", VA = "0x2362984", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60092A0")]
	[Address(RVA = "0x2362AFC", Offset = "0x2362AFC", VA = "0x2362AFC")]
	public bool PlayAvatarVoiceShot(uint avatarID, AvatarVoice_Trigger_Type triggerType, string language = "", bool random = false, [Optional] Action audioEndCB)
	{
		return default(bool);
	}

	[Token(Token = "0x60092A1")]
	[Address(RVA = "0x23629E4", Offset = "0x23629E4", VA = "0x23629E4")]
	public void StopAvatarVoiceShot()
	{
	}

	[Token(Token = "0x60092A2")]
	[Address(RVA = "0x2362C74", Offset = "0x2362C74", VA = "0x2362C74")]
	public bool AudioABIsReady(ResourceID resourceID)
	{
		return default(bool);
	}
}
