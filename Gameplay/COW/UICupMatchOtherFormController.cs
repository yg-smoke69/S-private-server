using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002075")]
public class UICupMatchOtherFormController : UINavigationController
{
	[Token(Token = "0x2002076")]
	public class NavArgs
	{
		[Token(Token = "0x400CB85")]
		[FieldOffset(Offset = "0x8")]
		public int cpKey;

		[Token(Token = "0x400CB86")]
		[FieldOffset(Offset = "0xC")]
		public uint teamID;

		[Token(Token = "0x400CB87")]
		[FieldOffset(Offset = "0x10")]
		public bool self;

		[Token(Token = "0x400CB88")]
		[FieldOffset(Offset = "0x14")]
		public uint scaleType;

		[Token(Token = "0x600A694")]
		[Address(RVA = "0x2AA9BE8", Offset = "0x2AA9BE8", VA = "0x2AA9BE8")]
		public NavArgs()
		{
		}
	}

	[Token(Token = "0x400CB80")]
	[FieldOffset(Offset = "0x68")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CB81")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_TeamID;

	[Token(Token = "0x400CB82")]
	[FieldOffset(Offset = "0x70")]
	private UICupMatchOtherFormView m_View;

	[Token(Token = "0x400CB83")]
	[FieldOffset(Offset = "0x74")]
	private UICupMatchTeamProfileOtherController m_TeamCtrl;

	[Token(Token = "0x400CB84")]
	[FieldOffset(Offset = "0x78")]
	private UIStandardDrawerTabController m_DrawerTabCtrl;

	[Token(Token = "0x600A68B")]
	[Address(RVA = "0x2AA92C8", Offset = "0x2AA92C8", VA = "0x2AA92C8")]
	public UICupMatchOtherFormController()
	{
	}

	[Token(Token = "0x600A68C")]
	[Address(RVA = "0x2AA934C", Offset = "0x2AA934C", VA = "0x2AA934C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A68D")]
	[Address(RVA = "0x2AA93F4", Offset = "0x2AA93F4", VA = "0x2AA93F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A68E")]
	[Address(RVA = "0x2AA94F8", Offset = "0x2AA94F8", VA = "0x2AA94F8", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600A68F")]
	[Address(RVA = "0x2AA988C", Offset = "0x2AA988C", VA = "0x2AA988C")]
	public void CreateTab()
	{
	}

	[Token(Token = "0x600A690")]
	[Address(RVA = "0x2AA96E8", Offset = "0x2AA96E8", VA = "0x2AA96E8")]
	public void CreateTeamPage()
	{
	}

	[Token(Token = "0x600A691")]
	[Address(RVA = "0x2AA9B08", Offset = "0x2AA9B08", VA = "0x2AA9B08")]
	private void OnBtnTeamPageClick()
	{
	}

	[Token(Token = "0x600A692")]
	[Address(RVA = "0x2AA9BD8", Offset = "0x2AA9BD8", VA = "0x2AA9BD8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A693")]
	[Address(RVA = "0x2AA9BE0", Offset = "0x2AA9BE0", VA = "0x2AA9BE0")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
