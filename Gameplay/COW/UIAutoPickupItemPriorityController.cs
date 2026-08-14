using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024A1")]
public class UIAutoPickupItemPriorityController : UIBaseController
{
	[Token(Token = "0x400E2FC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly List<string> ShowTipsParam;

	[Token(Token = "0x400E2FD")]
	[FieldOffset(Offset = "0x28")]
	private UICommonSettingMovableItemView m_View;

	[Token(Token = "0x400E2FE")]
	[FieldOffset(Offset = "0x2C")]
	private UIAutoPickupItemPriorityViewData m_ViewData;

	[Token(Token = "0x400E2FF")]
	[FieldOffset(Offset = "0x4")]
	private static Callback _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x17001121")]
	public UIAutoPickupItemPriorityViewData ViewData
	{
		[Token(Token = "0x600D17C")]
		[Address(RVA = "0x1E74020", Offset = "0x1E74020", VA = "0x1E74020")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600D17B")]
	[Address(RVA = "0x1E73F9C", Offset = "0x1E73F9C", VA = "0x1E73F9C")]
	public UIAutoPickupItemPriorityController()
	{
	}

	[Token(Token = "0x600D17D")]
	[Address(RVA = "0x1E74078", Offset = "0x1E74078", VA = "0x1E74078")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D17E")]
	[Address(RVA = "0x1E74120", Offset = "0x1E74120", VA = "0x1E74120", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D17F")]
	[Address(RVA = "0x1E74804", Offset = "0x1E74804", VA = "0x1E74804")]
	public void SetViewData(UIAutoPickupItemPriorityViewData viewData)
	{
	}

	[Token(Token = "0x600D180")]
	[Address(RVA = "0x1E74BEC", Offset = "0x1E74BEC", VA = "0x1E74BEC")]
	private void SetupSlider()
	{
	}

	[Token(Token = "0x600D181")]
	[Address(RVA = "0x1E74DD8", Offset = "0x1E74DD8", VA = "0x1E74DD8")]
	public void CheckReachBorderStatus(int index, int length)
	{
	}

	[Token(Token = "0x600D182")]
	[Address(RVA = "0x1E74F18", Offset = "0x1E74F18", VA = "0x1E74F18")]
	private void OpenMenuItemControllers()
	{
	}

	[Token(Token = "0x600D183")]
	[Address(RVA = "0x1E75308", Offset = "0x1E75308", VA = "0x1E75308")]
	private void CloseMenuItemControllers()
	{
	}

	[Token(Token = "0x600D184")]
	[Address(RVA = "0x1E754BC", Offset = "0x1E754BC", VA = "0x1E754BC")]
	public void CloseMenuItemControllersIfUnfolded()
	{
	}

	[Token(Token = "0x600D185")]
	[Address(RVA = "0x1E755C8", Offset = "0x1E755C8", VA = "0x1E755C8")]
	private void OnUpArrowBtn()
	{
	}

	[Token(Token = "0x600D186")]
	[Address(RVA = "0x1E75964", Offset = "0x1E75964", VA = "0x1E75964")]
	private void OnDownArrowBtn()
	{
	}

	[Token(Token = "0x600D187")]
	[Address(RVA = "0x1E75BE0", Offset = "0x1E75BE0", VA = "0x1E75BE0")]
	private void OnIncreaseBtn()
	{
	}

	[Token(Token = "0x600D188")]
	[Address(RVA = "0x1E75D18", Offset = "0x1E75D18", VA = "0x1E75D18")]
	private void OnDecreaseBtn()
	{
	}

	[Token(Token = "0x600D189")]
	[Address(RVA = "0x1E75E50", Offset = "0x1E75E50", VA = "0x1E75E50")]
	private static void OnTipBtn()
	{
	}

	[Token(Token = "0x600D18A")]
	[Address(RVA = "0x1E75FF8", Offset = "0x1E75FF8", VA = "0x1E75FF8")]
	private void OnExpandToggleChange()
	{
	}

	[Token(Token = "0x600D18B")]
	[Address(RVA = "0x1E76204", Offset = "0x1E76204", VA = "0x1E76204")]
	private void OnSliderValueChange()
	{
	}

	[Token(Token = "0x600D18C")]
	[Address(RVA = "0x1E74328", Offset = "0x1E74328", VA = "0x1E74328")]
	private void AddEventDelegates()
	{
	}

	[Token(Token = "0x600D18D")]
	[Address(RVA = "0x1E75844", Offset = "0x1E75844", VA = "0x1E75844")]
	public void OnPriorityMenuItemMoved(UIAutoPickupItemPriorityController controller, int id, bool up)
	{
	}

	[Token(Token = "0x600D18E")]
	[Address(RVA = "0x1E76B9C", Offset = "0x1E76B9C", VA = "0x1E76B9C")]
	public UIWidget GetArrowDownButtonForGuidance()
	{
		return null;
	}

	[Token(Token = "0x600D18F")]
	[Address(RVA = "0x1E76C0C", Offset = "0x1E76C0C", VA = "0x1E76C0C")]
	public UIWidget GetActiveSliderContainerForGuidance()
	{
		return null;
	}

	[Token(Token = "0x600D190")]
	[Address(RVA = "0x1E74B50", Offset = "0x1E74B50", VA = "0x1E74B50")]
	private float GetAlphaWithHierarchy()
	{
		return default(float);
	}

	[Token(Token = "0x600D192")]
	[Address(RVA = "0x1E76E78", Offset = "0x1E76E78", VA = "0x1E76E78")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
