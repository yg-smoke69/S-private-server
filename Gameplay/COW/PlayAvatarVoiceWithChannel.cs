using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E7B")]
public class PlayAvatarVoiceWithChannel : _Attribute
{
	[Token(Token = "0x2001E7C")]
	private sealed class _003CPlayAvatarVoiceShot_003Ec__AnonStorey0
	{
		[Token(Token = "0x400BF9F")]
		[FieldOffset(Offset = "0x8")]
		internal AvatarVoice_Trigger_Type triggerType;

		[Token(Token = "0x60092A7")]
		[Address(RVA = "0x1C07150", Offset = "0x1C07150", VA = "0x1C07150")]
		public _003CPlayAvatarVoiceShot_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60092A8")]
		[Address(RVA = "0x1C07380", Offset = "0x1C07380", VA = "0x1C07380")]
		internal bool _003C_003Em__0(AssistantAudioData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400BF9C")]
	[FieldOffset(Offset = "0x8")]
	private int m_VoiceTicket;

	[Token(Token = "0x400BF9D")]
	[FieldOffset(Offset = "0xC")]
	private uint m_LastAvatarId;

	[Token(Token = "0x400BF9E")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, uint> m_RunningVoice;

	[Token(Token = "0x60092A3")]
	[Address(RVA = "0x1C06A2C", Offset = "0x1C06A2C", VA = "0x1C06A2C")]
	public PlayAvatarVoiceWithChannel()
	{
	}

	[Token(Token = "0x60092A4")]
	[Address(RVA = "0x1C06AB8", Offset = "0x1C06AB8", VA = "0x1C06AB8", Slot = "4")]
	public bool PlayAvatarVoiceShot(uint avatarID, AvatarVoice_Trigger_Type triggerType, string language = "", bool random = false, [Optional] Action audioEndCB)
	{
		return default(bool);
	}

	[Token(Token = "0x60092A5")]
	[Address(RVA = "0x1C07158", Offset = "0x1C07158", VA = "0x1C07158")]
	private bool CanPlayShot(uint avatarID)
	{
		return default(bool);
	}

	[Token(Token = "0x60092A6")]
	[Address(RVA = "0x1C0727C", Offset = "0x1C0727C", VA = "0x1C0727C", Slot = "5")]
	public void StopAvatarVoiceShot()
	{
	}
}
