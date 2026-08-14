using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002BA4")]
internal class UIUGCHotMapController : UIBaseController
{
	[Token(Token = "0x2002BA5")]
	private enum ERecType
	{
		[Token(Token = "0x4010AFC")]
		EditorChoice,
		[Token(Token = "0x4010AFD")]
		Hot
	}

	[Token(Token = "0x4010AF6")]
	[FieldOffset(Offset = "0x28")]
	private UIUGCHotMapView m_View;

	[Token(Token = "0x4010AF7")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelSceneEdit m_Model;

	[Token(Token = "0x4010AF8")]
	[FieldOffset(Offset = "0x30")]
	private SceneEditSlotInfo m_SlotInfo;

	[Token(Token = "0x4010AF9")]
	[FieldOffset(Offset = "0x34")]
	private ERecType m_RecType;

	[Token(Token = "0x4010AFA")]
	[FieldOffset(Offset = "0x38")]
	private bool m_MainEditorChoice;

	[Token(Token = "0x6012092")]
	[Address(RVA = "0x2B9671C", Offset = "0x2B9671C", VA = "0x2B9671C")]
	public UIUGCHotMapController()
	{
	}

	[Token(Token = "0x6012093")]
	[Address(RVA = "0x2B967A0", Offset = "0x2B967A0", VA = "0x2B967A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012094")]
	[Address(RVA = "0x2B96848", Offset = "0x2B96848", VA = "0x2B96848", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012095")]
	[Address(RVA = "0x2B96A14", Offset = "0x2B96A14", VA = "0x2B96A14")]
	public void SetViewData(WorkshopHotInfo info)
	{
	}

	[Token(Token = "0x6012096")]
	[Address(RVA = "0x2B97114", Offset = "0x2B97114", VA = "0x2B97114")]
	public void SetViewData(WorkshopEditorChoiceInfo info, bool isMain)
	{
	}

	[Token(Token = "0x6012097")]
	[Address(RVA = "0x2B96B2C", Offset = "0x2B96B2C", VA = "0x2B96B2C")]
	private void RefreshUI(string cdn)
	{
	}

	[Token(Token = "0x6012098")]
	[Address(RVA = "0x2B971C0", Offset = "0x2B971C0", VA = "0x2B971C0")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x6012099")]
	[Address(RVA = "0x2B97520", Offset = "0x2B97520", VA = "0x2B97520")]
	private void _003CRefreshUI_003Em__0()
	{
	}

	[Token(Token = "0x601209A")]
	[Address(RVA = "0x2B97600", Offset = "0x2B97600", VA = "0x2B97600")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
