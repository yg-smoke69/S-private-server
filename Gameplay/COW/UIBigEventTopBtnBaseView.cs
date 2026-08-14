using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001F96")]
public class UIBigEventTopBtnBaseView : MonoBehaviour
{
	[Token(Token = "0x400C637")]
	[FieldOffset(Offset = "0xC")]
	public UIButton BtnSugarToken;

	[Token(Token = "0x400C638")]
	[FieldOffset(Offset = "0x10")]
	public UISprite SugarTokenIcon;

	[Token(Token = "0x400C639")]
	[FieldOffset(Offset = "0x14")]
	public UILabel SugarTokenCount;

	[Token(Token = "0x400C63A")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnClose;

	[Token(Token = "0x400C63B")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnStoreToken;

	[Token(Token = "0x400C63C")]
	[FieldOffset(Offset = "0x20")]
	public UISprite StoreTokenIcon;

	[Token(Token = "0x400C63D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel StoreTokenCount;

	[Token(Token = "0x400C63E")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid BtnGrid;

	[Token(Token = "0x400C63F")]
	[FieldOffset(Offset = "0x2C")]
	public Transform SugarTipPos;

	[Token(Token = "0x400C640")]
	[FieldOffset(Offset = "0x30")]
	public Transform StoreTipPos;

	[Token(Token = "0x400C641")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ExchangeStoreGoToBtn;

	[Token(Token = "0x6009D3F")]
	[Address(RVA = "0x301A1AC", Offset = "0x301A1AC", VA = "0x301A1AC")]
	public UIBigEventTopBtnBaseView()
	{
	}
}
