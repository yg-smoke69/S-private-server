using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2001EA6")]
public class UIDigitaluniverseBActivityCardItemController : UIBaseController
{
	[Token(Token = "0x400C0B5")]
	[FieldOffset(Offset = "0x28")]
	private UIDigitaluniverseBActivityCardItemView m_View;

	[Token(Token = "0x400C0B6")]
	[FieldOffset(Offset = "0x2C")]
	private int m_Index;

	[Token(Token = "0x400C0B7")]
	private const int OFFSETHEIGHT = 30;

	[Token(Token = "0x400C0B8")]
	private const string TIME_FORMAT_Y = "{0:D2}";

	[Token(Token = "0x400C0B9")]
	private const string TIME_FORMAT_START_END = "{0}-{1}";

	[Token(Token = "0x400C0BA")]
	[FieldOffset(Offset = "0x30")]
	private UIModelDigitaluniverseB m_Model;

	[Token(Token = "0x400C0BB")]
	private const byte STEP1_READY = 1;

	[Token(Token = "0x400C0BC")]
	private const byte STEP2_READY = 2;

	[Token(Token = "0x400C0BD")]
	private const byte ALL_STEP_READY = 3;

	[Token(Token = "0x400C0BE")]
	[FieldOffset(Offset = "0x34")]
	private byte m_ReadyFlag;

	[Token(Token = "0x6009403")]
	[Address(RVA = "0x2D8E234", Offset = "0x2D8E234", VA = "0x2D8E234")]
	public UIDigitaluniverseBActivityCardItemController()
	{
	}

	[Token(Token = "0x6009404")]
	[Address(RVA = "0x2D8E2B8", Offset = "0x2D8E2B8", VA = "0x2D8E2B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009405")]
	[Address(RVA = "0x2D8E360", Offset = "0x2D8E360", VA = "0x2D8E360", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009406")]
	[Address(RVA = "0x2D8E534", Offset = "0x2D8E534", VA = "0x2D8E534")]
	private void SetupDefaultState()
	{
	}

	[Token(Token = "0x6009407")]
	[Address(RVA = "0x2D8C7A8", Offset = "0x2D8C7A8", VA = "0x2D8C7A8")]
	public void SetViewData(int i, DigitaluniverseBPostcardDesc desc)
	{
	}

	[Token(Token = "0x6009408")]
	[Address(RVA = "0x2D8E6A8", Offset = "0x2D8E6A8", VA = "0x2D8E6A8")]
	private void SetCDN(DigitaluniverseBPostcardDesc desc)
	{
	}

	[Token(Token = "0x6009409")]
	[Address(RVA = "0x2D8F978", Offset = "0x2D8F978", VA = "0x2D8F978")]
	private void SetDateTime(string startTime, string endTime)
	{
	}

	[Token(Token = "0x600940A")]
	[Address(RVA = "0x2D8E860", Offset = "0x2D8E860", VA = "0x2D8E860")]
	private void SetDetail(DigitaluniverseBPostcardDesc desc)
	{
	}

	[Token(Token = "0x600940B")]
	[Address(RVA = "0x2D8FC28", Offset = "0x2D8FC28", VA = "0x2D8FC28")]
	private void OnShareBtn()
	{
	}

	[Token(Token = "0x600940C")]
	[Address(RVA = "0x2D90034", Offset = "0x2D90034", VA = "0x2D90034", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600940D")]
	[Address(RVA = "0x2D90200", Offset = "0x2D90200", VA = "0x2D90200", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600940E")]
	[Address(RVA = "0x2D903CC", Offset = "0x2D903CC", VA = "0x2D903CC", Slot = "28")]
	public override void AfterSharePreview()
	{
	}

	[Token(Token = "0x600940F")]
	[Address(RVA = "0x2D8C83C", Offset = "0x2D8C83C", VA = "0x2D8C83C")]
	public void RefreshShareBubble()
	{
	}

	[Token(Token = "0x6009410")]
	[Address(RVA = "0x2D8D644", Offset = "0x2D8D644", VA = "0x2D8D644")]
	public void HideShareBubble()
	{
	}

	[Token(Token = "0x6009411")]
	[Address(RVA = "0x2D8D310", Offset = "0x2D8D310", VA = "0x2D8D310")]
	public int GetIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6009412")]
	[Address(RVA = "0x2D8C974", Offset = "0x2D8C974", VA = "0x2D8C974")]
	public void SetTypeWriterEnable()
	{
	}

	[Token(Token = "0x6009413")]
	[Address(RVA = "0x2D8DCB8", Offset = "0x2D8DCB8", VA = "0x2D8DCB8")]
	public void PlayPassIconAni()
	{
	}

	[Token(Token = "0x6009414")]
	[Address(RVA = "0x2D8DBC4", Offset = "0x2D8DBC4", VA = "0x2D8DBC4")]
	public void SetPassIconState(bool flag)
	{
	}

	[Token(Token = "0x6009415")]
	[Address(RVA = "0x2D8CA04", Offset = "0x2D8CA04", VA = "0x2D8CA04")]
	public void SetPassAniEnableState(bool flag)
	{
	}

	[Token(Token = "0x6009416")]
	[Address(RVA = "0x2D8CA9C", Offset = "0x2D8CA9C", VA = "0x2D8CA9C")]
	public void SetPassIconShiningState(bool flag)
	{
	}

	[Token(Token = "0x6009417")]
	[Address(RVA = "0x2D905F0", Offset = "0x2D905F0", VA = "0x2D905F0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009418")]
	[Address(RVA = "0x2D905F8", Offset = "0x2D905F8", VA = "0x2D905F8")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6009419")]
	[Address(RVA = "0x2D90600", Offset = "0x2D90600", VA = "0x2D90600")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x600941A")]
	[Address(RVA = "0x2D90608", Offset = "0x2D90608", VA = "0x2D90608")]
	public void _003C_003EiFixBaseProxy_AfterSharePreview()
	{
	}
}
