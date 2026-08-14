using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D54")]
public class AnimAudioEvt : MonoBehaviour
{
	[Token(Token = "0x401164C")]
	[FieldOffset(Offset = "0xC")]
	public EAnimAudioBusType AudioBus;

	[Token(Token = "0x401164D")]
	[FieldOffset(Offset = "0x10")]
	private GameObject CurrentPlayShot;

	[Token(Token = "0x401164E")]
	[FieldOffset(Offset = "0x14")]
	private int m_InsertMusicTicket;

	[Token(Token = "0x401164F")]
	[FieldOffset(Offset = "0x18")]
	private bool m_bIsNeedResumeAudioVolume;

	[Token(Token = "0x6012F7B")]
	[Address(RVA = "0x14C56E8", Offset = "0x14C56E8", VA = "0x14C56E8")]
	public AnimAudioEvt()
	{
	}

	[Token(Token = "0x6012F7C")]
	[Address(RVA = "0x14C5700", Offset = "0x14C5700", VA = "0x14C5700")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6012F7D")]
	[Address(RVA = "0x14C5AAC", Offset = "0x14C5AAC", VA = "0x14C5AAC")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6012F7E")]
	[Address(RVA = "0x14C5C40", Offset = "0x14C5C40", VA = "0x14C5C40")]
	public void PlayAnimAudioBackGroundEvt(string voice_resourceid)
	{
	}

	[Token(Token = "0x6012F7F")]
	[Address(RVA = "0x14C5E84", Offset = "0x14C5E84", VA = "0x14C5E84")]
	public void PlayAnimAudioLoopBackGroundEvt(string voice_resourceid)
	{
	}

	[Token(Token = "0x6012F80")]
	[Address(RVA = "0x14C60C4", Offset = "0x14C60C4", VA = "0x14C60C4")]
	public void PlayAnimOneShotEvt(string voice_resourceid)
	{
	}

	[Token(Token = "0x6012F81")]
	[Address(RVA = "0x14C59B8", Offset = "0x14C59B8", VA = "0x14C59B8")]
	public void StopEvtShot()
	{
	}

	[Token(Token = "0x6012F82")]
	[Address(RVA = "0x14C6568", Offset = "0x14C6568", VA = "0x14C6568")]
	public void PlayAnimOnlyOneShotEvt(string voice_resourceid)
	{
	}

	[Token(Token = "0x6012F83")]
	[Address(RVA = "0x14C5894", Offset = "0x14C5894", VA = "0x14C5894")]
	public void ResumeAudioVolume()
	{
	}

	[Token(Token = "0x6012F84")]
	[Address(RVA = "0x14C69E0", Offset = "0x14C69E0", VA = "0x14C69E0")]
	public void ReduceAudioVolume(float volumerate)
	{
	}

	[Token(Token = "0x6012F85")]
	[Address(RVA = "0x14C6B40", Offset = "0x14C6B40", VA = "0x14C6B40")]
	public void DispatchAnimEvent(string eventName)
	{
	}
}
