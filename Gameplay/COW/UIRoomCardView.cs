using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002D50")]
public class UIRoomCardView : MonoBehaviour
{
	[Token(Token = "0x2002D51")]
	private sealed class _003CRefreshLabel_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011645")]
		[FieldOffset(Offset = "0x8")]
		internal EInventory.ItemSubType type;

		[Token(Token = "0x4011646")]
		[FieldOffset(Offset = "0xC")]
		internal UIRoomCardView _0024this;

		[Token(Token = "0x6012F72")]
		[Address(RVA = "0x23B9FC8", Offset = "0x23B9FC8", VA = "0x23B9FC8")]
		public _003CRefreshLabel_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6012F73")]
		[Address(RVA = "0x23BA2C0", Offset = "0x23BA2C0", VA = "0x23BA2C0")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x401163C")]
	[FieldOffset(Offset = "0xC")]
	public UIButton Button;

	[Token(Token = "0x401163D")]
	[FieldOffset(Offset = "0x10")]
	public UILabel Label;

	[Token(Token = "0x401163E")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Sprite;

	[Token(Token = "0x401163F")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget Widget;

	[Token(Token = "0x4011640")]
	[FieldOffset(Offset = "0x1C")]
	public BoxCollider ButtonCollider;

	[Token(Token = "0x4011641")]
	[FieldOffset(Offset = "0x20")]
	public Transform Container;

	[Token(Token = "0x4011642")]
	[FieldOffset(Offset = "0x24")]
	private CSSharedItemData ItemData;

	[Token(Token = "0x4011643")]
	[FieldOffset(Offset = "0x28")]
	private UICountDownLabel m_CountDownLabel;

	[Token(Token = "0x4011644")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x6012F6C")]
	[Address(RVA = "0x23B977C", Offset = "0x23B977C", VA = "0x23B977C")]
	public UIRoomCardView()
	{
	}

	[Token(Token = "0x6012F6D")]
	[Address(RVA = "0x23B8A30", Offset = "0x23B8A30", VA = "0x23B8A30")]
	public void SetActive(bool active)
	{
	}

	[Token(Token = "0x6012F6E")]
	[Address(RVA = "0x23B8AC0", Offset = "0x23B8AC0", VA = "0x23B8AC0")]
	public void Init(EInventory.ItemSubType type, bool showTime)
	{
	}

	[Token(Token = "0x6012F6F")]
	[Address(RVA = "0x23B9784", Offset = "0x23B9784", VA = "0x23B9784")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x6012F70")]
	[Address(RVA = "0x23B8C70", Offset = "0x23B8C70", VA = "0x23B8C70")]
	public void RefreshLabel(EInventory.ItemSubType type, bool showTime)
	{
	}

	[Token(Token = "0x6012F71")]
	[Address(RVA = "0x23B9FD0", Offset = "0x23B9FD0", VA = "0x23B9FD0")]
	private void UpdateItemData(EInventory.ItemSubType type, bool showTime)
	{
	}
}
