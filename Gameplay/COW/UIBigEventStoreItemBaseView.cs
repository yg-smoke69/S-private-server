using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2001F93")]
public class UIBigEventStoreItemBaseView : MonoBehaviour
{
	[Token(Token = "0x400C624")]
	[FieldOffset(Offset = "0xC")]
	public Transform ItemContainer;

	[Token(Token = "0x400C625")]
	[FieldOffset(Offset = "0x10")]
	public GameObject NodeCanBuy;

	[Token(Token = "0x400C626")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnExchange;

	[Token(Token = "0x400C627")]
	[FieldOffset(Offset = "0x18")]
	public UISprite TokenIcon;

	[Token(Token = "0x400C628")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TokenCost;

	[Token(Token = "0x400C629")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NodeSoldOut;

	[Token(Token = "0x400C62A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject NodeOwned;

	[Token(Token = "0x400C62B")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ExchangeTimes;

	[Token(Token = "0x400C62C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NodeLock;

	[Token(Token = "0x400C62D")]
	[FieldOffset(Offset = "0x30")]
	public Transform NoLimitBtnPos;

	[Token(Token = "0x400C62E")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnSoldOut;

	[Token(Token = "0x400C62F")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnOwned;

	[Token(Token = "0x400C630")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite NodeCanBuyBg;

	[Token(Token = "0x6009D32")]
	[Address(RVA = "0x3019230", Offset = "0x3019230", VA = "0x3019230")]
	public UIBigEventStoreItemBaseView()
	{
	}
}
