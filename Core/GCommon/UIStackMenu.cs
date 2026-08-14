using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200416A")]
public class UIStackMenu : MonoBehaviour
{
	[Token(Token = "0x200416B")]
	private sealed class _003CTrySelectByID_003Ec__AnonStorey0
	{
		[Token(Token = "0x401B723")]
		[FieldOffset(Offset = "0x8")]
		internal string mainID;

		[Token(Token = "0x601ABC0")]
		[Address(RVA = "0x2BBD850", Offset = "0x2BBD850", VA = "0x2BBD850")]
		public _003CTrySelectByID_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601ABC1")]
		[Address(RVA = "0x2BBE4B4", Offset = "0x2BBE4B4", VA = "0x2BBE4B4")]
		internal bool _003C_003Em__0(UIMenuItem e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401B71B")]
	[FieldOffset(Offset = "0xC")]
	public UIMenuItem mainMenuTemplate;

	[Token(Token = "0x401B71C")]
	[FieldOffset(Offset = "0x10")]
	public UIMenuItem subMenuTeamplate;

	[Token(Token = "0x401B71D")]
	[FieldOffset(Offset = "0x14")]
	public Transform menuRootPoint;

	[Token(Token = "0x401B71E")]
	[FieldOffset(Offset = "0x18")]
	public List<UIMenuItem> m_MainMenus;

	[Token(Token = "0x401B71F")]
	[FieldOffset(Offset = "0x1C")]
	public Dictionary<UIMenuItem, List<UIMenuItem>> m_Menus;

	[Token(Token = "0x401B720")]
	[FieldOffset(Offset = "0x20")]
	private UIMenuItem m_SelectedMainMenu;

	[Token(Token = "0x401B721")]
	[FieldOffset(Offset = "0x24")]
	private UIMenuItem m_SelectedSubMenu;

	[Token(Token = "0x401B722")]
	[FieldOffset(Offset = "0x28")]
	private string m_TrySelectSubMenuID;

	[Token(Token = "0x601ABB0")]
	[Address(RVA = "0x2BBD048", Offset = "0x2BBD048", VA = "0x2BBD048")]
	public UIStackMenu()
	{
	}

	[Token(Token = "0x601ABB1")]
	[Address(RVA = "0x2BBD108", Offset = "0x2BBD108", VA = "0x2BBD108")]
	private void Awake()
	{
	}

	[Token(Token = "0x601ABB2")]
	[Address(RVA = "0x2BBD1A0", Offset = "0x2BBD1A0", VA = "0x2BBD1A0")]
	private void Start()
	{
	}

	[Token(Token = "0x601ABB3")]
	[Address(RVA = "0x2BBD1A4", Offset = "0x2BBD1A4", VA = "0x2BBD1A4")]
	private void Update()
	{
	}

	[Token(Token = "0x601ABB4")]
	[Address(RVA = "0x2BBD1A8", Offset = "0x2BBD1A8", VA = "0x2BBD1A8")]
	public void AddMenu(UIMenuItemData mainMenu, List<UIMenuItemData> subMenu)
	{
	}

	[Token(Token = "0x601ABB5")]
	[Address(RVA = "0x2BBD6C4", Offset = "0x2BBD6C4", VA = "0x2BBD6C4")]
	public void Build([Optional] string selectMainID, [Optional] string selectSubID)
	{
	}

	[Token(Token = "0x601ABB6")]
	[Address(RVA = "0x2BBD6C8", Offset = "0x2BBD6C8", VA = "0x2BBD6C8")]
	public void TrySelectByID(string mainID, string subID)
	{
	}

	[Token(Token = "0x601ABB7")]
	[Address(RVA = "0x2BBDAF4", Offset = "0x2BBDAF4", VA = "0x2BBDAF4")]
	public void Clear()
	{
	}

	[Token(Token = "0x601ABB8")]
	[Address(RVA = "0x2BBD858", Offset = "0x2BBD858", VA = "0x2BBD858")]
	public void OnMainMenuSelected(UIMenuItem menuUI)
	{
	}

	[Token(Token = "0x601ABB9")]
	[Address(RVA = "0x2BBDE24", Offset = "0x2BBDE24", VA = "0x2BBDE24")]
	public void OnSubMenuSelected(UIMenuItem menuUI)
	{
	}

	[Token(Token = "0x601ABBA")]
	[Address(RVA = "0x2BBDF04", Offset = "0x2BBDF04", VA = "0x2BBDF04")]
	public void Reposion()
	{
	}

	[Token(Token = "0x601ABBB")]
	[Address(RVA = "0x2BBD398", Offset = "0x2BBD398", VA = "0x2BBD398")]
	public UIMenuItem CreateMainMenu(UIMenuItemData menu)
	{
		return null;
	}

	[Token(Token = "0x601ABBC")]
	[Address(RVA = "0x2BBD508", Offset = "0x2BBD508", VA = "0x2BBD508")]
	public UIMenuItem CreateSubMenu(UIMenuItemData subMenu, UIMenuItem mainMenuUI)
	{
		return null;
	}

	[Token(Token = "0x601ABBD")]
	[Address(RVA = "0x2BBE328", Offset = "0x2BBE328", VA = "0x2BBE328")]
	public static Vector3 LocalPositionSetY(Transform target, float y)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601ABBE")]
	[Address(RVA = "0x2BBE3D4", Offset = "0x2BBE3D4", VA = "0x2BBE3D4")]
	public static Vector3 LocalPositionSetX(Transform target, float x)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601ABBF")]
	[Address(RVA = "0x2BBE480", Offset = "0x2BBE480", VA = "0x2BBE480")]
	private bool _003COnMainMenuSelected_003Em__0(UIMenuItem e)
	{
		return default(bool);
	}
}
