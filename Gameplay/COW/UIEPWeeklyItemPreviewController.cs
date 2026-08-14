using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020E1")]
public class UIEPWeeklyItemPreviewController : MonoBehaviour
{
	[Token(Token = "0x400CDB3")]
	[FieldOffset(Offset = "0xC")]
	public GameObject LockGo;

	[Token(Token = "0x400CDB4")]
	[FieldOffset(Offset = "0x10")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x400CDB5")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ProgressCnt;

	[Token(Token = "0x400CDB6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Desc;

	[Token(Token = "0x400CDB7")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Btn;

	[Token(Token = "0x400CDB8")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture CDNBG;

	[Token(Token = "0x400CDB9")]
	[FieldOffset(Offset = "0x24")]
	private EPWeeklyQuestGroupData m_Data;

	[Token(Token = "0x400CDBA")]
	[FieldOffset(Offset = "0x28")]
	private int index;

	[Token(Token = "0x400CDBB")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel OpenDay;

	[Token(Token = "0x600AA3A")]
	[Address(RVA = "0x2BB4688", Offset = "0x2BB4688", VA = "0x2BB4688")]
	public UIEPWeeklyItemPreviewController()
	{
	}

	[Token(Token = "0x600AA3B")]
	[Address(RVA = "0x2BB4690", Offset = "0x2BB4690", VA = "0x2BB4690")]
	public void Awake()
	{
	}

	[Token(Token = "0x600AA3C")]
	[Address(RVA = "0x2BB47B0", Offset = "0x2BB47B0", VA = "0x2BB47B0")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600AA3D")]
	[Address(RVA = "0x2BB49A4", Offset = "0x2BB49A4", VA = "0x2BB49A4")]
	public void SetData(int idx, EPWeeklyQuestGroupData data)
	{
	}

	[Token(Token = "0x600AA3E")]
	[Address(RVA = "0x2BB4D88", Offset = "0x2BB4D88", VA = "0x2BB4D88")]
	private void SetCDN(string url)
	{
	}

	[Token(Token = "0x600AA3F")]
	[Address(RVA = "0x2BB4A2C", Offset = "0x2BB4A2C", VA = "0x2BB4A2C")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x600AA40")]
	[Address(RVA = "0x2BB5114", Offset = "0x2BB5114", VA = "0x2BB5114")]
	private void RefreshProcess()
	{
	}

	[Token(Token = "0x600AA41")]
	[Address(RVA = "0x2BB4F24", Offset = "0x2BB4F24", VA = "0x2BB4F24")]
	private string GetOpenDay(DateTime sTime)
	{
		return null;
	}
}
