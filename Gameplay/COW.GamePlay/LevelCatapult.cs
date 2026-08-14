using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005EC")]
public class LevelCatapult : BaseLevelObject
{
	[Token(Token = "0x20005ED")]
	private class NDCKBDDEGMO : ShadowStateBase
	{
		[Token(Token = "0x40044BC")]
		[FieldOffset(Offset = "0x10")]
		public Quaternion FBMPKHMBHAM;

		[Token(Token = "0x40044BD")]
		[FieldOffset(Offset = "0x20")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x600242F")]
		[Address(RVA = "0x237D7F8", Offset = "0x237D7F8", VA = "0x237D7F8")]
		public NDCKBDDEGMO()
		{
		}
	}

	[Token(Token = "0x20005EE")]
	public enum JJKKNFCBPNC
	{
		[Token(Token = "0x40044BF")]
		SYNC,
		[Token(Token = "0x40044C0")]
		SYNCLIST,
		[Token(Token = "0x40044C1")]
		GET_IN,
		[Token(Token = "0x40044C2")]
		GET_OUT,
		[Token(Token = "0x40044C3")]
		LAUNCH
	}

	[Token(Token = "0x40044A5")]
	[FieldOffset(Offset = "0x78")]
	private IHAAMHPPLMG KFMGKCJMCAM;

	[Token(Token = "0x40044A6")]
	[FieldOffset(Offset = "0x90")]
	public Transform InCatapultPosition;

	[Token(Token = "0x40044A7")]
	[FieldOffset(Offset = "0x94")]
	public Transform OutCatapultPosition;

	[Token(Token = "0x40044A8")]
	[FieldOffset(Offset = "0x98")]
	public Vector3 originalForward;

	[Token(Token = "0x40044A9")]
	[FieldOffset(Offset = "0xA4")]
	public Transform BoardRoot;

	[Token(Token = "0x40044AA")]
	[FieldOffset(Offset = "0xA8")]
	public Transform HorizontalRotRoot;

	[Token(Token = "0x40044AB")]
	[FieldOffset(Offset = "0xAC")]
	public Transform VerticalRotRoot;

	[Token(Token = "0x40044AC")]
	[FieldOffset(Offset = "0xB0")]
	public Transform ChargingEffectAnchor;

	[Token(Token = "0x40044AD")]
	[FieldOffset(Offset = "0xB4")]
	private Collider ABLAOAPPBGF;

	[Token(Token = "0x40044AE")]
	[FieldOffset(Offset = "0xB8")]
	private GameObject EKEGOFFILNO;

	[Token(Token = "0x40044AF")]
	[FieldOffset(Offset = "0xBC")]
	private GameObject ADHKNFNFDJI;

	[Token(Token = "0x40044B0")]
	[FieldOffset(Offset = "0xC0")]
	private GameObject NHMFCHDKNDF;

	[Token(Token = "0x40044B1")]
	[FieldOffset(Offset = "0xC4")]
	private GameObject CMPGGFKEOBC;

	[Token(Token = "0x40044B2")]
	[FieldOffset(Offset = "0xC8")]
	private GameObject BLOPMKOBFCC;

	[Token(Token = "0x40044B3")]
	[FieldOffset(Offset = "0xCC")]
	private GameObject OOHGOCDLADH;

	[Token(Token = "0x40044B4")]
	[FieldOffset(Offset = "0xD0")]
	private uint INLCOOIGKHF;

	[Token(Token = "0x40044B5")]
	[FieldOffset(Offset = "0xD4")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x40044B6")]
	[FieldOffset(Offset = "0xD8")]
	private NDCKBDDEGMO PLGAAJABBHA;

	[Token(Token = "0x40044B7")]
	[FieldOffset(Offset = "0xDC")]
	private Vector3 AEOBLCHJOJB;

	[Token(Token = "0x40044B8")]
	[FieldOffset(Offset = "0xE8")]
	private Quaternion JOHDIIAGLOK;

	[Token(Token = "0x40044B9")]
	[FieldOffset(Offset = "0xF8")]
	public float RotHorizontalRangeMinAngle;

	[Token(Token = "0x40044BA")]
	[FieldOffset(Offset = "0xFC")]
	public float RotHorizontalRangeMaxAngle;

	[Token(Token = "0x40044BB")]
	[FieldOffset(Offset = "0x100")]
	public float OriginalForwardAngle;

	[Token(Token = "0x170002E5")]
	public Vector3 BIKKBPJPALB
	{
		[Token(Token = "0x600240C")]
		[Address(RVA = "0x237D874", Offset = "0x237D874", VA = "0x237D874")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x600240D")]
		[Address(RVA = "0x237D8E4", Offset = "0x237D8E4", VA = "0x237D8E4")]
		set
		{
		}
	}

	[Token(Token = "0x170002E6")]
	public Quaternion PIOIOHIDAGE
	{
		[Token(Token = "0x600240E")]
		[Address(RVA = "0x237DC08", Offset = "0x237DC08", VA = "0x237DC08")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}
		[Token(Token = "0x600240F")]
		[Address(RVA = "0x237DC74", Offset = "0x237DC74", VA = "0x237DC74")]
		set
		{
		}
	}

	[Token(Token = "0x600240A")]
	[Address(RVA = "0x237D688", Offset = "0x237D688", VA = "0x237D688")]
	public LevelCatapult()
	{
	}

	[Token(Token = "0x600240B")]
	[Address(RVA = "0x237D800", Offset = "0x237D800", VA = "0x237D800")]
	public IHAAMHPPLMG PIDInCatapult()
	{
		return default(IHAAMHPPLMG);
	}

	[Token(Token = "0x6002410")]
	[Address(RVA = "0x237DA48", Offset = "0x237DA48", VA = "0x237DA48")]
	private void AHKGMDLJGDF()
	{
	}

	[Token(Token = "0x6002411")]
	[Address(RVA = "0x237E2B8", Offset = "0x237E2B8", VA = "0x237E2B8", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002412")]
	[Address(RVA = "0x237E844", Offset = "0x237E844", VA = "0x237E844", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002413")]
	[Address(RVA = "0x237E5FC", Offset = "0x237E5FC", VA = "0x237E5FC")]
	public void CalculateHorizontalRotationRange()
	{
	}

	[Token(Token = "0x6002414")]
	[Address(RVA = "0x237E9BC", Offset = "0x237E9BC", VA = "0x237E9BC")]
	public void PushSyncState(Quaternion KHGMEBFPGKA, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6002415")]
	[Address(RVA = "0x237EAEC", Offset = "0x237EAEC", VA = "0x237EAEC", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6002416")]
	[Address(RVA = "0x237EF60", Offset = "0x237EF60", VA = "0x237EF60", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002417")]
	[Address(RVA = "0x237F004", Offset = "0x237F004", VA = "0x237F004", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002418")]
	[Address(RVA = "0x237F43C", Offset = "0x237F43C", VA = "0x237F43C")]
	private bool CNKOBCDJGFM(Player PJOIFFLCDPM)
	{
		return default(bool);
	}

	[Token(Token = "0x6002419")]
	[Address(RVA = "0x237F568", Offset = "0x237F568", VA = "0x237F568")]
	private void HBJKIPNKBAK(Player PJOIFFLCDPM, bool KIEHGMEKBHI)
	{
	}

	[Token(Token = "0x600241A")]
	[Address(RVA = "0x237FD00", Offset = "0x237FD00", VA = "0x237FD00", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x600241B")]
	[Address(RVA = "0x23806CC", Offset = "0x23806CC", VA = "0x23806CC")]
	public void PrepareLaunch()
	{
	}

	[Token(Token = "0x600241C")]
	[Address(RVA = "0x2380D1C", Offset = "0x2380D1C", VA = "0x2380D1C")]
	public void RealLaunch()
	{
	}

	[Token(Token = "0x600241D")]
	[Address(RVA = "0x2381070", Offset = "0x2381070", VA = "0x2381070")]
	private void BMOKANNMAAO()
	{
	}

	[Token(Token = "0x600241E")]
	[Address(RVA = "0x237F76C", Offset = "0x237F76C", VA = "0x237F76C")]
	private void IKDLNFPFFJN()
	{
	}

	[Token(Token = "0x600241F")]
	[Address(RVA = "0x237F9C0", Offset = "0x237F9C0", VA = "0x237F9C0")]
	private void GEIEDOGODNJ()
	{
	}

	[Token(Token = "0x6002420")]
	[Address(RVA = "0x237DF20", Offset = "0x237DF20", VA = "0x237DF20")]
	private void DKPILNMGLMO()
	{
	}

	[Token(Token = "0x6002421")]
	[Address(RVA = "0x237E174", Offset = "0x237E174", VA = "0x237E174")]
	private void DPOHFKOHKHP()
	{
	}

	[Token(Token = "0x6002422")]
	[Address(RVA = "0x237FB04", Offset = "0x237FB04", VA = "0x237FB04")]
	private void EBOAAJKKFFJ()
	{
	}

	[Token(Token = "0x6002423")]
	[Address(RVA = "0x2380970", Offset = "0x2380970", VA = "0x2380970")]
	private void LAFNPLEILPH()
	{
	}

	[Token(Token = "0x6002424")]
	[Address(RVA = "0x238134C", Offset = "0x238134C", VA = "0x238134C", Slot = "23")]
	protected override void OnUpdateVisibleStateByStreamer(Vector3 MKGCDPNKMOB, Vector3 OANAHFHPBNB)
	{
	}

	[Token(Token = "0x6002425")]
	[Address(RVA = "0x23814D0", Offset = "0x23814D0", VA = "0x23814D0")]
	private void GDICILBGKIJ()
	{
	}

	[Token(Token = "0x6002426")]
	[Address(RVA = "0x237E8B0", Offset = "0x237E8B0", VA = "0x237E8B0")]
	private void GGBACBIFDCN()
	{
	}

	[Token(Token = "0x6002427")]
	[Address(RVA = "0x2380AD8", Offset = "0x2380AD8", VA = "0x2380AD8")]
	private void HHIFPCFILBP(GameObject ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6002428")]
	[Address(RVA = "0x2381134", Offset = "0x2381134", VA = "0x2381134")]
	private void MPBNCEODAED(ResourceID FCMOICILFBP, GameObject ECINOMEHBKA)
	{
	}

	[Token(Token = "0x6002429")]
	[Address(RVA = "0x2381964", Offset = "0x2381964", VA = "0x2381964")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x600242A")]
	[Address(RVA = "0x238196C", Offset = "0x238196C", VA = "0x238196C")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x600242B")]
	[Address(RVA = "0x2381974", Offset = "0x2381974", VA = "0x2381974")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x600242C")]
	[Address(RVA = "0x238197C", Offset = "0x238197C", VA = "0x238197C")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	[Token(Token = "0x600242D")]
	[Address(RVA = "0x2381984", Offset = "0x2381984", VA = "0x2381984")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x600242E")]
	[Address(RVA = "0x238198C", Offset = "0x238198C", VA = "0x238198C")]
	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}
}
