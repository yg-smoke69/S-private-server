using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002049")]
public class UIHudCSMysteryBoxOptionItemView : MonoBehaviour
{
	[Token(Token = "0x200204A")]
	public class MysterBoxData
	{
		[Token(Token = "0x400CA62")]
		[FieldOffset(Offset = "0x8")]
		public uint boxItemID;

		[Token(Token = "0x400CA63")]
		[FieldOffset(Offset = "0xC")]
		public uint boxUniqueID;

		[Token(Token = "0x400CA64")]
		[FieldOffset(Offset = "0x10")]
		public uint boxIndexID;

		[Token(Token = "0x400CA65")]
		[FieldOffset(Offset = "0x14")]
		public uint itemID;

		[Token(Token = "0x600A44C")]
		[Address(RVA = "0x1F19AE0", Offset = "0x1F19AE0", VA = "0x1F19AE0")]
		public MysterBoxData()
		{
		}
	}

	[Token(Token = "0x400CA5B")]
	[FieldOffset(Offset = "0xC")]
	public UIToggleButton ItemBtn;

	[Token(Token = "0x400CA5C")]
	[FieldOffset(Offset = "0x10")]
	public UILabel ItemName;

	[Token(Token = "0x400CA5D")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ItemSprite;

	[Token(Token = "0x400CA5E")]
	[FieldOffset(Offset = "0x18")]
	public UIButton HelpBtn;

	[Token(Token = "0x400CA5F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SelectedHL;

	[Token(Token = "0x400CA60")]
	[FieldOffset(Offset = "0x20")]
	private MysterBoxData m_BoxData;

	[Token(Token = "0x400CA61")]
	[FieldOffset(Offset = "0x24")]
	private UIHudCommonlTipsController m_CurrentTips;

	[Token(Token = "0x600A445")]
	[Address(RVA = "0x1F18F84", Offset = "0x1F18F84", VA = "0x1F18F84")]
	public UIHudCSMysteryBoxOptionItemView()
	{
	}

	[Token(Token = "0x600A446")]
	[Address(RVA = "0x1F18F8C", Offset = "0x1F18F8C", VA = "0x1F18F8C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600A447")]
	[Address(RVA = "0x1F191E4", Offset = "0x1F191E4", VA = "0x1F191E4")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600A448")]
	[Address(RVA = "0x1F19374", Offset = "0x1F19374", VA = "0x1F19374")]
	public void SetUIData(MysterBoxData data)
	{
	}

	[Token(Token = "0x600A449")]
	[Address(RVA = "0x1F19660", Offset = "0x1F19660", VA = "0x1F19660")]
	private void OnItemBtnClick()
	{
	}

	[Token(Token = "0x600A44A")]
	[Address(RVA = "0x1F197F0", Offset = "0x1F197F0", VA = "0x1F197F0")]
	private void OnHelpBtnClick()
	{
	}

	[Token(Token = "0x600A44B")]
	[Address(RVA = "0x1F19A60", Offset = "0x1F19A60", VA = "0x1F19A60")]
	private void OnOptionSelected(object[] data)
	{
	}
}
