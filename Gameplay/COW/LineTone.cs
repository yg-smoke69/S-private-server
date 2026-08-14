using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002395")]
public class LineTone : MonoBehaviour
{
	[Token(Token = "0x400DD94")]
	[FieldOffset(Offset = "0xC")]
	public Transform startPoint;

	[Token(Token = "0x400DD95")]
	[FieldOffset(Offset = "0x10")]
	public Transform endPoint;

	[Token(Token = "0x400DD96")]
	[FieldOffset(Offset = "0x14")]
	public Transform startEffect;

	[Token(Token = "0x400DD97")]
	[FieldOffset(Offset = "0x18")]
	public Transform endEffect;

	[Token(Token = "0x400DD98")]
	[FieldOffset(Offset = "0x1C")]
	public Transform perfectPos;

	[Token(Token = "0x400DD99")]
	[FieldOffset(Offset = "0x20")]
	public LineToneInputControl inputControl;

	[Token(Token = "0x400DD9A")]
	[FieldOffset(Offset = "0x24")]
	private MusicMiniGamePhaseOneGameData m_data;

	[Token(Token = "0x400DD9B")]
	[FieldOffset(Offset = "0x28")]
	private float toneCreateTime;

	[Token(Token = "0x400DD9C")]
	[FieldOffset(Offset = "0x2C")]
	private float startTime;

	[Token(Token = "0x400DD9D")]
	[FieldOffset(Offset = "0x30")]
	private float endTime;

	[Token(Token = "0x400DD9E")]
	[FieldOffset(Offset = "0x34")]
	private float prefectGap;

	[Token(Token = "0x400DD9F")]
	[FieldOffset(Offset = "0x38")]
	private float goodGap;

	[Token(Token = "0x400DDA0")]
	[FieldOffset(Offset = "0x3C")]
	private float completeGap;

	[Token(Token = "0x400DDA1")]
	[FieldOffset(Offset = "0x40")]
	private bool isStartDrag;

	[Token(Token = "0x400DDA2")]
	[FieldOffset(Offset = "0x41")]
	private bool hasStart;

	[Token(Token = "0x400DDA3")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 startPointInitPos;

	[Token(Token = "0x600C7D9")]
	[Address(RVA = "0xEC4044", Offset = "0xEC4044", VA = "0xEC4044")]
	public LineTone()
	{
	}

	[Token(Token = "0x600C7DA")]
	[Address(RVA = "0xEC404C", Offset = "0xEC404C", VA = "0xEC404C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600C7DB")]
	[Address(RVA = "0xEC40E0", Offset = "0xEC40E0", VA = "0xEC40E0")]
	public void StartTone(SingerMiniMusicGamePhaseOneConfigData conf, MusicMiniGamePhaseOneGameData mdata)
	{
	}

	[Token(Token = "0x600C7DC")]
	[Address(RVA = "0xEC42F8", Offset = "0xEC42F8", VA = "0xEC42F8")]
	public void ResetTone()
	{
	}

	[Token(Token = "0x600C7DD")]
	[Address(RVA = "0xEC49C4", Offset = "0xEC49C4", VA = "0xEC49C4")]
	private void Update()
	{
	}

	[Token(Token = "0x600C7DE")]
	[Address(RVA = "0xEC4DBC", Offset = "0xEC4DBC", VA = "0xEC4DBC")]
	public void StartDrag()
	{
	}

	[Token(Token = "0x600C7DF")]
	[Address(RVA = "0xEC4F48", Offset = "0xEC4F48", VA = "0xEC4F48")]
	public void PerfectTone()
	{
	}

	[Token(Token = "0x600C7E0")]
	[Address(RVA = "0xEC5350", Offset = "0xEC5350", VA = "0xEC5350")]
	public void GoodTone()
	{
	}

	[Token(Token = "0x600C7E1")]
	[Address(RVA = "0xEC55CC", Offset = "0xEC55CC", VA = "0xEC55CC")]
	public void CompleteTone()
	{
	}

	[Token(Token = "0x600C7E2")]
	[Address(RVA = "0xEC5848", Offset = "0xEC5848", VA = "0xEC5848")]
	public void MissTone()
	{
	}

	[Token(Token = "0x600C7E3")]
	[Address(RVA = "0xEC5A30", Offset = "0xEC5A30", VA = "0xEC5A30")]
	public void ShowDragStartEffect()
	{
	}

	[Token(Token = "0x600C7E4")]
	[Address(RVA = "0xEC5C10", Offset = "0xEC5C10", VA = "0xEC5C10")]
	public void ShowDragEndEffect()
	{
	}

	[Token(Token = "0x600C7E5")]
	[Address(RVA = "0xEC5DE8", Offset = "0xEC5DE8", VA = "0xEC5DE8")]
	public bool IsToneStart()
	{
		return default(bool);
	}

	[Token(Token = "0x600C7E6")]
	[Address(RVA = "0xEC51C4", Offset = "0xEC51C4", VA = "0xEC51C4")]
	private void LineToneFinish()
	{
	}
}
