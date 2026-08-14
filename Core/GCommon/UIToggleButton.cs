using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200416C")]
public class UIToggleButton : UIButton
{
	[Token(Token = "0x200416D")]
	public enum SwitchType
	{
		[Token(Token = "0x401B72F")]
		Alpha,
		[Token(Token = "0x401B730")]
		Active
	}

	[Token(Token = "0x200416E")]
	public delegate void OnSelectDelgate(UIToggleButton button);

	[Token(Token = "0x401B724")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject SelectedObject;

	[Token(Token = "0x401B725")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject UnSelectedObject;

	[Token(Token = "0x401B726")]
	[FieldOffset(Offset = "0xC4")]
	public bool IsDefault;

	[Token(Token = "0x401B727")]
	[FieldOffset(Offset = "0xC8")]
	public SwitchType Switch;

	[Token(Token = "0x401B728")]
	[FieldOffset(Offset = "0xCC")]
	private bool m_IsSelected;

	[Token(Token = "0x401B729")]
	[FieldOffset(Offset = "0xCD")]
	private bool m_Inited;

	[Token(Token = "0x401B72A")]
	[FieldOffset(Offset = "0xD0")]
	public OnSelectDelgate onSelect;

	[Token(Token = "0x401B72B")]
	[FieldOffset(Offset = "0xD4")]
	private UIWidget m_SelectWidget;

	[Token(Token = "0x401B72C")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_SelectEnable;

	[Token(Token = "0x401B72D")]
	[FieldOffset(Offset = "0xDC")]
	private UIWidget m_UnselectWidget;

	[Token(Token = "0x17001D77")]
	private UIWidget SelectWidget
	{
		[Token(Token = "0x601ABC3")]
		[Address(RVA = "0x2BBE4F8", Offset = "0x2BBE4F8", VA = "0x2BBE4F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D78")]
	private UIWidget UnselectWidget
	{
		[Token(Token = "0x601ABC4")]
		[Address(RVA = "0x2BBE6F0", Offset = "0x2BBE6F0", VA = "0x2BBE6F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001D79")]
	public bool IsSelected
	{
		[Token(Token = "0x601ABC5")]
		[Address(RVA = "0x2BBE8E8", Offset = "0x2BBE8E8", VA = "0x2BBE8E8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601ABC6")]
		[Address(RVA = "0x2BBE8F0", Offset = "0x2BBE8F0", VA = "0x2BBE8F0")]
		set
		{
		}
	}

	[Token(Token = "0x601ABC2")]
	[Address(RVA = "0x2BBE4E8", Offset = "0x2BBE4E8", VA = "0x2BBE4E8")]
	public UIToggleButton()
	{
	}

	[Token(Token = "0x601ABC7")]
	[Address(RVA = "0x2BBE970", Offset = "0x2BBE970", VA = "0x2BBE970")]
	private void Awake()
	{
	}

	[Token(Token = "0x601ABC8")]
	[Address(RVA = "0x2BBEA3C", Offset = "0x2BBEA3C", VA = "0x2BBEA3C", Slot = "7")]
	protected override void OnEnable()
	{
	}

	[Token(Token = "0x601ABC9")]
	[Address(RVA = "0x2BBE940", Offset = "0x2BBE940", VA = "0x2BBE940")]
	private void OnToggleSelected()
	{
	}

	[Token(Token = "0x601ABCA")]
	[Address(RVA = "0x2BBEE6C", Offset = "0x2BBEE6C", VA = "0x2BBEE6C")]
	public void RefreshButtonStates()
	{
	}

	[Token(Token = "0x601ABCB")]
	[Address(RVA = "0x2BBF230", Offset = "0x2BBF230", VA = "0x2BBF230")]
	public void SetButtonSelectEnable(bool enable)
	{
	}
}
