using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002399")]
public class Tone : MonoBehaviour
{
	[Token(Token = "0x400DDBD")]
	[FieldOffset(Offset = "0xC")]
	public Transform effectTrans;

	[Token(Token = "0x400DDBE")]
	[FieldOffset(Offset = "0x10")]
	public Transform completeEffectTrans;

	[Token(Token = "0x400DDBF")]
	[FieldOffset(Offset = "0x14")]
	public Transform clickEffectTrans;

	[Token(Token = "0x400DDC0")]
	[FieldOffset(Offset = "0x18")]
	private UIButton toneButton;

	[Token(Token = "0x400DDC1")]
	[FieldOffset(Offset = "0x1C")]
	private float prefectTime;

	[Token(Token = "0x400DDC2")]
	[FieldOffset(Offset = "0x20")]
	private float startTime;

	[Token(Token = "0x400DDC3")]
	[FieldOffset(Offset = "0x24")]
	private float prefectGap;

	[Token(Token = "0x400DDC4")]
	[FieldOffset(Offset = "0x28")]
	private float goodGap;

	[Token(Token = "0x400DDC5")]
	[FieldOffset(Offset = "0x2C")]
	private float completeGap;

	[Token(Token = "0x400DDC6")]
	[FieldOffset(Offset = "0x30")]
	private bool hasClick;

	[Token(Token = "0x400DDC7")]
	[FieldOffset(Offset = "0x31")]
	private bool isOver;

	[Token(Token = "0x400DDC8")]
	[FieldOffset(Offset = "0x34")]
	private int toneID;

	[Token(Token = "0x400DDC9")]
	[FieldOffset(Offset = "0x38")]
	private MusicMiniGamePhaseThreeGameData m_data;

	[Token(Token = "0x600C7F6")]
	[Address(RVA = "0x28ADE6C", Offset = "0x28ADE6C", VA = "0x28ADE6C")]
	public Tone()
	{
	}

	[Token(Token = "0x600C7F7")]
	[Address(RVA = "0x28ADE74", Offset = "0x28ADE74", VA = "0x28ADE74")]
	private void Start()
	{
	}

	[Token(Token = "0x600C7F8")]
	[Address(RVA = "0x28ADFF8", Offset = "0x28ADFF8", VA = "0x28ADFF8")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600C7F9")]
	[Address(RVA = "0x28AE168", Offset = "0x28AE168", VA = "0x28AE168")]
	private void Update()
	{
	}

	[Token(Token = "0x600C7FA")]
	[Address(RVA = "0x28AE424", Offset = "0x28AE424", VA = "0x28AE424")]
	public void ShowTone(SingerMiniMusicGamePhaseThreeConfigData configData, int toneID, float startTime, MusicMiniGamePhaseThreeGameData mdata)
	{
	}

	[Token(Token = "0x600C7FB")]
	[Address(RVA = "0x28AE580", Offset = "0x28AE580", VA = "0x28AE580")]
	private void OnClickToneButton()
	{
	}

	[Token(Token = "0x600C7FC")]
	[Address(RVA = "0x28AE704", Offset = "0x28AE704", VA = "0x28AE704")]
	public void PerfectTone()
	{
	}

	[Token(Token = "0x600C7FD")]
	[Address(RVA = "0x28AE888", Offset = "0x28AE888", VA = "0x28AE888")]
	public void GoodTone()
	{
	}

	[Token(Token = "0x600C7FE")]
	[Address(RVA = "0x28AEA0C", Offset = "0x28AEA0C", VA = "0x28AEA0C")]
	public void CompleteTone()
	{
	}

	[Token(Token = "0x600C7FF")]
	[Address(RVA = "0x28AE340", Offset = "0x28AE340", VA = "0x28AE340")]
	public void MissTone()
	{
	}

	[Token(Token = "0x600C800")]
	[Address(RVA = "0x28AEB90", Offset = "0x28AEB90", VA = "0x28AEB90")]
	private void ToneOver(ToneCompleteType completeType)
	{
	}
}
