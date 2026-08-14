using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002729")]
public class UIHudDebugTestPopMenuController : UIBaseController
{
	[Token(Token = "0x400F1AE")]
	[FieldOffset(Offset = "0x28")]
	public UIHudDebugTestPopMenuView m_View;

	[Token(Token = "0x400F1AF")]
	[FieldOffset(Offset = "0x2C")]
	private UIPopMenuSmallControler m_DebugMenuCtr;

	[Token(Token = "0x400F1B0")]
	[FieldOffset(Offset = "0x30")]
	private string m_DebugName;

	[Token(Token = "0x400F1B1")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<string, Action<object>> m_DebugDict;

	[Token(Token = "0x400F1B2")]
	[FieldOffset(Offset = "0x38")]
	private bool m_ShowMoveSpeed;

	[Token(Token = "0x400F1B3")]
	[FieldOffset(Offset = "0x39")]
	private bool isPause;

	[Token(Token = "0x400F1B4")]
	[FieldOffset(Offset = "0x3C")]
	private GUIStyle GUIStyle;

	[Token(Token = "0x600EE43")]
	[Address(RVA = "0x1CD0094", Offset = "0x1CD0094", VA = "0x1CD0094")]
	public UIHudDebugTestPopMenuController()
	{
	}

	[Token(Token = "0x600EE44")]
	[Address(RVA = "0x1CD013C", Offset = "0x1CD013C", VA = "0x1CD013C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EE45")]
	[Address(RVA = "0x1CD01E4", Offset = "0x1CD01E4", VA = "0x1CD01E4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EE46")]
	[Address(RVA = "0x1CD06D4", Offset = "0x1CD06D4", VA = "0x1CD06D4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600EE47")]
	[Address(RVA = "0x1CD0360", Offset = "0x1CD0360", VA = "0x1CD0360")]
	private void InitDebugPopMenu()
	{
	}

	[Token(Token = "0x600EE48")]
	[Address(RVA = "0x1CD0808", Offset = "0x1CD0808", VA = "0x1CD0808")]
	private void SetDebugDict()
	{
	}

	[Token(Token = "0x600EE49")]
	[Address(RVA = "0x1CD0C74", Offset = "0x1CD0C74", VA = "0x1CD0C74")]
	private void SwitchPlayer(object obj)
	{
	}

	[Token(Token = "0x600EE4A")]
	[Address(RVA = "0x1CD0D84", Offset = "0x1CD0D84", VA = "0x1CD0D84")]
	private void AddPlayer(object obj)
	{
	}

	[Token(Token = "0x600EE4B")]
	[Address(RVA = "0x1CD0E94", Offset = "0x1CD0E94", VA = "0x1CD0E94")]
	private void RecipeDebug(object param)
	{
	}

	[Token(Token = "0x600EE4C")]
	[Address(RVA = "0x1CD1000", Offset = "0x1CD1000", VA = "0x1CD1000")]
	private void DebugSkateboard(object param)
	{
	}

	[Token(Token = "0x600EE4D")]
	[Address(RVA = "0x1CD116C", Offset = "0x1CD116C", VA = "0x1CD116C")]
	private void ToggleColliderDebug(object param)
	{
	}

	[Token(Token = "0x600EE4E")]
	[Address(RVA = "0x1CD12CC", Offset = "0x1CD12CC", VA = "0x1CD12CC")]
	private void ReSkyDiving(object param)
	{
	}

	[Token(Token = "0x600EE4F")]
	[Address(RVA = "0x1CD14FC", Offset = "0x1CD14FC", VA = "0x1CD14FC")]
	private void PauseGame(object param)
	{
	}

	[Token(Token = "0x600EE50")]
	[Address(RVA = "0x1CD161C", Offset = "0x1CD161C", VA = "0x1CD161C")]
	private void GamingVault(object param)
	{
	}

	[Token(Token = "0x600EE51")]
	[Address(RVA = "0x1CD173C", Offset = "0x1CD173C", VA = "0x1CD173C")]
	private void OnDebugTestClick()
	{
	}

	[Token(Token = "0x600EE52")]
	[Address(RVA = "0x1CD05B4", Offset = "0x1CD05B4", VA = "0x1CD05B4")]
	private void OnShowDebugUI(object[] param)
	{
	}

	[Token(Token = "0x600EE53")]
	[Address(RVA = "0x1CD18D4", Offset = "0x1CD18D4", VA = "0x1CD18D4")]
	private void ShowMoveSpeed(object param)
	{
	}

	[Token(Token = "0x600EE54")]
	[Address(RVA = "0x1CD1940", Offset = "0x1CD1940", VA = "0x1CD1940")]
	private void OnGUI()
	{
	}

	[Token(Token = "0x600EE55")]
	[Address(RVA = "0x1CD1B6C", Offset = "0x1CD1B6C", VA = "0x1CD1B6C")]
	private PopMenuData _003COnDebugTestClick_003Em__0(string item)
	{
		return null;
	}

	[Token(Token = "0x600EE56")]
	[Address(RVA = "0x1CD1CB0", Offset = "0x1CD1CB0", VA = "0x1CD1CB0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EE57")]
	[Address(RVA = "0x1CD1CB8", Offset = "0x1CD1CB8", VA = "0x1CD1CB8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
