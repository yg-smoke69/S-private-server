using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002CDF")]
public class DescButtonView : MonoBehaviour
{
	[Token(Token = "0x40111DE")]
	[FieldOffset(Offset = "0xC")]
	private UIButton m_Button;

	[Token(Token = "0x40111DF")]
	[FieldOffset(Offset = "0x10")]
	private UISprite m_Icon0;

	[Token(Token = "0x40111E0")]
	[FieldOffset(Offset = "0x14")]
	private UILabel m_Label0;

	[Token(Token = "0x40111E1")]
	[FieldOffset(Offset = "0x18")]
	private UISprite m_Icon1;

	[Token(Token = "0x40111E2")]
	[FieldOffset(Offset = "0x1C")]
	private UILabel m_Label1;

	[Token(Token = "0x40111E3")]
	[FieldOffset(Offset = "0x20")]
	private UIButton m_Button1;

	[Token(Token = "0x40111E4")]
	[FieldOffset(Offset = "0x24")]
	private UILabel[] m_LabelTitles;

	[Token(Token = "0x40111E5")]
	[FieldOffset(Offset = "0x28")]
	private Action m_Callback;

	[Token(Token = "0x40111E6")]
	[FieldOffset(Offset = "0x2C")]
	private Action m_Callback1;

	[Token(Token = "0x40111E7")]
	public const string DEFAULT_STRING = "";

	[Token(Token = "0x6012C6F")]
	[Address(RVA = "0x23214E4", Offset = "0x23214E4", VA = "0x23214E4")]
	public DescButtonView()
	{
	}

	[Token(Token = "0x6012C70")]
	[Address(RVA = "0x23214EC", Offset = "0x23214EC", VA = "0x23214EC")]
	public void SetData(string title0, string icon0, Action action, string title1 = "", string icon1 = "", [Optional] Action action1)
	{
	}

	[Token(Token = "0x6012C71")]
	[Address(RVA = "0x2321F98", Offset = "0x2321F98", VA = "0x2321F98")]
	private void OnClickButton()
	{
	}

	[Token(Token = "0x6012C72")]
	[Address(RVA = "0x2321FAC", Offset = "0x2321FAC", VA = "0x2321FAC")]
	private void OnClickButton1()
	{
	}
}
