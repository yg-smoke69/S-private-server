using System;
using System.Runtime.InteropServices;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002CE0")]
public class DescToggleView : MonoBehaviour
{
	[Token(Token = "0x40111E8")]
	[FieldOffset(Offset = "0xC")]
	private GameObject m_Select;

	[Token(Token = "0x40111E9")]
	[FieldOffset(Offset = "0x10")]
	private GameObject m_Unselect;

	[Token(Token = "0x40111EA")]
	[FieldOffset(Offset = "0x14")]
	private UILabel m_SelectLabel;

	[Token(Token = "0x40111EB")]
	[FieldOffset(Offset = "0x18")]
	private UISprite m_SelectIcon;

	[Token(Token = "0x40111EC")]
	[FieldOffset(Offset = "0x1C")]
	private UISprite m_SelectBG;

	[Token(Token = "0x40111ED")]
	[FieldOffset(Offset = "0x20")]
	private UILabel m_UnselectLabel;

	[Token(Token = "0x40111EE")]
	[FieldOffset(Offset = "0x24")]
	private UISprite m_UnselectIcon;

	[Token(Token = "0x40111EF")]
	[FieldOffset(Offset = "0x28")]
	private UISprite m_UnselectBG;

	[Token(Token = "0x40111F0")]
	[FieldOffset(Offset = "0x2C")]
	private UITipsButton m_Reddot;

	[Token(Token = "0x40111F1")]
	[FieldOffset(Offset = "0x30")]
	private int _003CTabType_003Ek__BackingField;

	[Token(Token = "0x40111F2")]
	private const string DEFAULT_STRING = "";

	[Token(Token = "0x40111F3")]
	[FieldOffset(Offset = "0x34")]
	private UIWidget m_Widget;

	[Token(Token = "0x40111F4")]
	[FieldOffset(Offset = "0x38")]
	private BoxCollider m_Collider;

	[Token(Token = "0x40111F5")]
	[FieldOffset(Offset = "0x3C")]
	private UIToggleButton m_Toggle;

	[Token(Token = "0x40111F6")]
	[FieldOffset(Offset = "0x40")]
	private Action m_OnSelect;

	[Token(Token = "0x40111F7")]
	[FieldOffset(Offset = "0x44")]
	private Action m_OnUnselect;

	[Token(Token = "0x1700134E")]
	public int TabType
	{
		[Token(Token = "0x6012C75")]
		[Address(RVA = "0x2321FD0", Offset = "0x2321FD0", VA = "0x2321FD0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6012C74")]
		[Address(RVA = "0x2321FC8", Offset = "0x2321FC8", VA = "0x2321FC8")]
		private set
		{
		}
	}

	[Token(Token = "0x1700134F")]
	private UIWidget CurWidget
	{
		[Token(Token = "0x6012C76")]
		[Address(RVA = "0x2321FD8", Offset = "0x2321FD8", VA = "0x2321FD8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001350")]
	public BoxCollider CurCollider
	{
		[Token(Token = "0x6012C77")]
		[Address(RVA = "0x2322088", Offset = "0x2322088", VA = "0x2322088")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001351")]
	public UIToggleButton CurToggle
	{
		[Token(Token = "0x6012C78")]
		[Address(RVA = "0x2322138", Offset = "0x2322138", VA = "0x2322138")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6012C73")]
	[Address(RVA = "0x2321FC0", Offset = "0x2321FC0", VA = "0x2321FC0")]
	public DescToggleView()
	{
	}

	[Token(Token = "0x6012C79")]
	[Address(RVA = "0x23221E8", Offset = "0x23221E8", VA = "0x23221E8")]
	private void Start()
	{
	}

	[Token(Token = "0x6012C7A")]
	[Address(RVA = "0x23222C8", Offset = "0x23222C8", VA = "0x23222C8")]
	private void OnClickToggle()
	{
	}

	[Token(Token = "0x6012C7B")]
	[Address(RVA = "0x2322318", Offset = "0x2322318", VA = "0x2322318")]
	public void SetData(int tabType, string selectLabel, string unselectLabel, Action onSelect, [Optional] Action onUnselect, ETipsType tipsType = ETipsType.None, string selectBG = "", string unselectBG = "", string selectIcon = "", string unselectIcon = "")
	{
	}

	[Token(Token = "0x6012C7C")]
	[Address(RVA = "0x23228A8", Offset = "0x23228A8", VA = "0x23228A8")]
	public void AdjustWidth(int index, int width, float space)
	{
	}
}
