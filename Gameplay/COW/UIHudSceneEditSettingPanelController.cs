using System;
using System.Collections;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002343")]
public class UIHudSceneEditSettingPanelController : UIBaseController
{
	[Token(Token = "0x2002344")]
	private sealed class _003CGetModeURL_003Ec__AnonStorey1
	{
		[Token(Token = "0x400DBBD")]
		[FieldOffset(Offset = "0x8")]
		internal uint gameMode;

		[Token(Token = "0x400DBBE")]
		[FieldOffset(Offset = "0xC")]
		internal int ugcModeTemplateID;

		[Token(Token = "0x600C44F")]
		[Address(RVA = "0x16AD500", Offset = "0x16AD500", VA = "0x16AD500")]
		public _003CGetModeURL_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600C450")]
		[Address(RVA = "0x16AD508", Offset = "0x16AD508", VA = "0x16AD508")]
		internal bool _003C_003Em__0(WorkshopCreateNewConfigData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002345")]
	private sealed class _003CCloseAndReopenModeSettingWindowCoro_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DBBF")]
		[FieldOffset(Offset = "0x8")]
		internal UIHudSceneEditSettingPanelController _0024this;

		[Token(Token = "0x400DBC0")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400DBC1")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400DBC2")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010C2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C453")]
			[Address(RVA = "0x16AD454", Offset = "0x16AD454", VA = "0x16AD454", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010C3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C454")]
			[Address(RVA = "0x16AD45C", Offset = "0x16AD45C", VA = "0x16AD45C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C451")]
		[Address(RVA = "0x16AD3B8", Offset = "0x16AD3B8", VA = "0x16AD3B8")]
		public _003CCloseAndReopenModeSettingWindowCoro_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C452")]
		[Address(RVA = "0x16AD3C0", Offset = "0x16AD3C0", VA = "0x16AD3C0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C455")]
		[Address(RVA = "0x16AD464", Offset = "0x16AD464", VA = "0x16AD464", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C456")]
		[Address(RVA = "0x16AD478", Offset = "0x16AD478", VA = "0x16AD478", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DBB5")]
	[FieldOffset(Offset = "0x28")]
	private bool m_isShow;

	[Token(Token = "0x400DBB6")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelUGCModeEdit m_Model;

	[Token(Token = "0x400DBB7")]
	[FieldOffset(Offset = "0x30")]
	private JPPGAJBAAKK m_Game;

	[Token(Token = "0x400DBB8")]
	[FieldOffset(Offset = "0x34")]
	private UISceneEditGameScene m_Scene;

	[Token(Token = "0x400DBB9")]
	[FieldOffset(Offset = "0x38")]
	private UIHudSceneEditSettingPanelView m_View;

	[Token(Token = "0x400DBBA")]
	[FieldOffset(Offset = "0x3C")]
	private UIModeEditPanelController m_ModeSettingController;

	[Token(Token = "0x400DBBB")]
	[FieldOffset(Offset = "0x40")]
	private uint m_CachedGameMode;

	[Token(Token = "0x400DBBC")]
	[FieldOffset(Offset = "0x44")]
	private int m_CachedUGCModeTemplate;

	[Token(Token = "0x600C434")]
	[Address(RVA = "0x24F1B90", Offset = "0x24F1B90", VA = "0x24F1B90")]
	public UIHudSceneEditSettingPanelController()
	{
	}

	[Token(Token = "0x600C435")]
	[Address(RVA = "0x24F1C1C", Offset = "0x24F1C1C", VA = "0x24F1C1C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C436")]
	[Address(RVA = "0x24F1CC4", Offset = "0x24F1CC4", VA = "0x24F1CC4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C437")]
	[Address(RVA = "0x24F26BC", Offset = "0x24F26BC", VA = "0x24F26BC")]
	private void ResetUIState()
	{
	}

	[Token(Token = "0x600C438")]
	[Address(RVA = "0x24F2BC8", Offset = "0x24F2BC8", VA = "0x24F2BC8")]
	private void ShowPanel()
	{
	}

	[Token(Token = "0x600C439")]
	[Address(RVA = "0x24F3058", Offset = "0x24F3058", VA = "0x24F3058")]
	private void HidePanel()
	{
	}

	[Token(Token = "0x600C43A")]
	[Address(RVA = "0x24F3288", Offset = "0x24F3288", VA = "0x24F3288")]
	private void HideAfterAnimation()
	{
	}

	[Token(Token = "0x600C43B")]
	[Address(RVA = "0x24F3300", Offset = "0x24F3300", VA = "0x24F3300")]
	private void ShowTip(string key)
	{
	}

	[Token(Token = "0x600C43C")]
	[Address(RVA = "0x24F2CD8", Offset = "0x24F2CD8", VA = "0x24F2CD8")]
	private void UpdateModeRelated()
	{
	}

	[Token(Token = "0x600C43D")]
	[Address(RVA = "0x24F3558", Offset = "0x24F3558", VA = "0x24F3558")]
	private string GetModeURL(uint gameMode, int ugcModeTemplateID)
	{
		return null;
	}

	[Token(Token = "0x600C43E")]
	[Address(RVA = "0x24F377C", Offset = "0x24F377C", VA = "0x24F377C")]
	private void OpenClearSceneWindow()
	{
	}

	[Token(Token = "0x600C43F")]
	[Address(RVA = "0x24F3A60", Offset = "0x24F3A60", VA = "0x24F3A60")]
	private void OpenModeSettingWindow()
	{
	}

	[Token(Token = "0x600C440")]
	[Address(RVA = "0x24F3DD8", Offset = "0x24F3DD8", VA = "0x24F3DD8")]
	private void CloseAndReopenModeSettingWindow(object[] data)
	{
	}

	[Token(Token = "0x600C441")]
	[Address(RVA = "0x24F3EFC", Offset = "0x24F3EFC", VA = "0x24F3EFC")]
	private IEnumerator CloseAndReopenModeSettingWindowCoro()
	{
		return null;
	}

	[Token(Token = "0x600C442")]
	[Address(RVA = "0x24F3FC8", Offset = "0x24F3FC8", VA = "0x24F3FC8")]
	private void OnToggleIntersection(UIToggleButton selectButton)
	{
	}

	[Token(Token = "0x600C443")]
	[Address(RVA = "0x24F444C", Offset = "0x24F444C", VA = "0x24F444C")]
	private void OnToggleGrid(UIToggleButton selectButton)
	{
	}

	[Token(Token = "0x600C444")]
	[Address(RVA = "0x24F45E8", Offset = "0x24F45E8", VA = "0x24F45E8")]
	private void OnToggleFriendGroupInvitation(UIToggleButton selectButton)
	{
	}

	[Token(Token = "0x600C445")]
	[Address(RVA = "0x24F4760", Offset = "0x24F4760", VA = "0x24F4760")]
	private void OnToggleGroup(UIToggleButton selectButton)
	{
	}

	[Token(Token = "0x600C446")]
	[Address(RVA = "0x24F4318", Offset = "0x24F4318", VA = "0x24F4318")]
	private void PlayToggleAudio()
	{
	}

	[Token(Token = "0x600C447")]
	[Address(RVA = "0x24F4BFC", Offset = "0x24F4BFC", VA = "0x24F4BFC")]
	private void OnSliderChanged()
	{
	}

	[Token(Token = "0x600C448")]
	[Address(RVA = "0x24F4F14", Offset = "0x24F4F14", VA = "0x24F4F14")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600C449")]
	[Address(RVA = "0x24F4F78", Offset = "0x24F4F78", VA = "0x24F4F78")]
	private void _003COnUIInit_003Em__1()
	{
	}

	[Token(Token = "0x600C44A")]
	[Address(RVA = "0x24F4FDC", Offset = "0x24F4FDC", VA = "0x24F4FDC")]
	private void _003COnUIInit_003Em__2(object[] args)
	{
	}

	[Token(Token = "0x600C44B")]
	[Address(RVA = "0x24F4FE0", Offset = "0x24F4FE0", VA = "0x24F4FE0")]
	private void _003COnUIInit_003Em__3(object[] args)
	{
	}

	[Token(Token = "0x600C44C")]
	[Address(RVA = "0x24F4FE4", Offset = "0x24F4FE4", VA = "0x24F4FE4")]
	private void _003COnUIInit_003Em__4(object[] args)
	{
	}

	[Token(Token = "0x600C44D")]
	[Address(RVA = "0x24F4FE8", Offset = "0x24F4FE8", VA = "0x24F4FE8")]
	private void _003CUpdateModeRelated_003Em__5()
	{
	}

	[Token(Token = "0x600C44E")]
	[Address(RVA = "0x24F50C8", Offset = "0x24F50C8", VA = "0x24F50C8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
