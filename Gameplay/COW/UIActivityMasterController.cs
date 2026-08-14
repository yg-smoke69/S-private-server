using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F66")]
internal class UIActivityMasterController : UIActivityPopWindowBase, _Attribute
{
	[Token(Token = "0x2001F67")]
	public enum ActivityCategory
	{
		[Token(Token = "0x400C53C")]
		None,
		[Token(Token = "0x400C53D")]
		Activity,
		[Token(Token = "0x400C53E")]
		Announcement,
		[Token(Token = "0x400C53F")]
		SignIn,
		[Token(Token = "0x400C540")]
		EPChallenge,
		[Token(Token = "0x400C541")]
		FestivalActivity1,
		[Token(Token = "0x400C542")]
		FestivalActivity2,
		[Token(Token = "0x400C543")]
		MegaFestival,
		[Token(Token = "0x400C544")]
		NewAnnouncement,
		[Token(Token = "0x400C545")]
		FestivalActivity3
	}

	[Token(Token = "0x2001F68")]
	private sealed class _003CWaitInitHttpRequest_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400C546")]
		[FieldOffset(Offset = "0x8")]
		internal HttpRequest request;

		[Token(Token = "0x400C547")]
		[FieldOffset(Offset = "0xC")]
		internal UIActivityMasterController _0024this;

		[Token(Token = "0x400C548")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400C549")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400C54A")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x17000F95")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6009BA5")]
			[Address(RVA = "0x2FB9314", Offset = "0x2FB9314", VA = "0x2FB9314", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F96")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6009BA6")]
			[Address(RVA = "0x2FB931C", Offset = "0x2FB931C", VA = "0x2FB931C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009BA3")]
		[Address(RVA = "0x2FB78FC", Offset = "0x2FB78FC", VA = "0x2FB78FC")]
		public _003CWaitInitHttpRequest_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6009BA4")]
		[Address(RVA = "0x2FB91B4", Offset = "0x2FB91B4", VA = "0x2FB91B4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009BA7")]
		[Address(RVA = "0x2FB9324", Offset = "0x2FB9324", VA = "0x2FB9324", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6009BA8")]
		[Address(RVA = "0x2FB9338", Offset = "0x2FB9338", VA = "0x2FB9338", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400C536")]
	[FieldOffset(Offset = "0x9C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C537")]
	[FieldOffset(Offset = "0xA0")]
	private UIModelAnnouncement m_ModelAnnouncement;

	[Token(Token = "0x400C538")]
	[FieldOffset(Offset = "0xA4")]
	private IEnumerator m_WaitInitHttpRequest;

	[Token(Token = "0x400C539")]
	[FieldOffset(Offset = "0xA8")]
	private string m_TabPath;

	[Token(Token = "0x400C53A")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<ActivityGroupDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6009B8A")]
	[Address(RVA = "0x2FB68EC", Offset = "0x2FB68EC", VA = "0x2FB68EC")]
	public UIActivityMasterController()
	{
	}

	[Token(Token = "0x6009B8B")]
	[Address(RVA = "0x2FB6AFC", Offset = "0x2FB6AFC", VA = "0x2FB6AFC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009B8C")]
	[Address(RVA = "0x2FB6BCC", Offset = "0x2FB6BCC", VA = "0x2FB6BCC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009B8D")]
	[Address(RVA = "0x2FB7210", Offset = "0x2FB7210", VA = "0x2FB7210")]
	private void OnContentChanged(object[] data)
	{
	}

	[Token(Token = "0x6009B8E")]
	[Address(RVA = "0x2FB76C0", Offset = "0x2FB76C0", VA = "0x2FB76C0", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6009B8F")]
	[Address(RVA = "0x2FB77C4", Offset = "0x2FB77C4", VA = "0x2FB77C4", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x6009B90")]
	[Address(RVA = "0x2FB7124", Offset = "0x2FB7124", VA = "0x2FB7124")]
	private IEnumerator WaitInitHttpRequest(HttpRequest request)
	{
		return null;
	}

	[Token(Token = "0x6009B91")]
	[Address(RVA = "0x2FB7904", Offset = "0x2FB7904", VA = "0x2FB7904", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6009B92")]
	[Address(RVA = "0x2FB7BB0", Offset = "0x2FB7BB0", VA = "0x2FB7BB0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6009B93")]
	[Address(RVA = "0x2FB7D8C", Offset = "0x2FB7D8C", VA = "0x2FB7D8C", Slot = "44")]
	public override void PrepareTopTabData()
	{
	}

	[Token(Token = "0x6009B94")]
	[Address(RVA = "0x2FB8534", Offset = "0x2FB8534", VA = "0x2FB8534")]
	private CategoryTabData PrepareActivityFestival(EventTabType festivalType)
	{
		return null;
	}

	[Token(Token = "0x6009B95")]
	[Address(RVA = "0x2FB87CC", Offset = "0x2FB87CC", VA = "0x2FB87CC", Slot = "47")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009B96")]
	[Address(RVA = "0x2FB8A24", Offset = "0x2FB8A24", VA = "0x2FB8A24", Slot = "48")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009B97")]
	[Address(RVA = "0x2FB8AB8", Offset = "0x2FB8AB8", VA = "0x2FB8AB8", Slot = "46")]
	protected override int GetTabPriority(CategoryTabData tabData)
	{
		return default(int);
	}

	[Token(Token = "0x6009B98")]
	[Address(RVA = "0x2FB8E5C", Offset = "0x2FB8E5C", VA = "0x2FB8E5C")]
	private UIActivityBaseController _003CPrepareTopTabData_003Em__0()
	{
		return null;
	}

	[Token(Token = "0x6009B99")]
	[Address(RVA = "0x2FB8F98", Offset = "0x2FB8F98", VA = "0x2FB8F98")]
	private UIActivityBaseController _003CPrepareTopTabData_003Em__1()
	{
		return null;
	}

	[Token(Token = "0x6009B9A")]
	[Address(RVA = "0x2FB9048", Offset = "0x2FB9048", VA = "0x2FB9048")]
	private UIActivityBaseController _003CPrepareActivityFestival_003Em__2()
	{
		return null;
	}

	[Token(Token = "0x6009B9B")]
	[Address(RVA = "0x2FB90F8", Offset = "0x2FB90F8", VA = "0x2FB90F8")]
	private static bool _003CGetTabPriority_003Em__3(ActivityGroupDesc e)
	{
		return default(bool);
	}

	[Token(Token = "0x6009B9C")]
	[Address(RVA = "0x2FB9128", Offset = "0x2FB9128", VA = "0x2FB9128")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009B9D")]
	[Address(RVA = "0x2FB912C", Offset = "0x2FB912C", VA = "0x2FB912C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6009B9E")]
	[Address(RVA = "0x2FB9134", Offset = "0x2FB9134", VA = "0x2FB9134")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x6009B9F")]
	[Address(RVA = "0x2FB913C", Offset = "0x2FB913C", VA = "0x2FB913C")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6009BA0")]
	[Address(RVA = "0x2FB9144", Offset = "0x2FB9144", VA = "0x2FB9144")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6009BA1")]
	[Address(RVA = "0x2FB9148", Offset = "0x2FB9148", VA = "0x2FB9148")]
	public void _003C_003EiFixBaseProxy_PrepareTopTabData()
	{
	}

	[Token(Token = "0x6009BA2")]
	[Address(RVA = "0x2FB914C", Offset = "0x2FB914C", VA = "0x2FB914C")]
	public int _003C_003EiFixBaseProxy_GetTabPriority(CategoryTabData P0)
	{
		return default(int);
	}
}
