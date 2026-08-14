using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005E9")]
public class LevelCannon : BaseLevelObject
{
	[Token(Token = "0x20005EA")]
	private class CEKDKEDHJBI : ShadowStateBase
	{
		[Token(Token = "0x400449D")]
		[FieldOffset(Offset = "0x10")]
		public Quaternion FBMPKHMBHAM;

		[Token(Token = "0x400449E")]
		[FieldOffset(Offset = "0x20")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x6002409")]
		[Address(RVA = "0x2378654", Offset = "0x2378654", VA = "0x2378654")]
		public CEKDKEDHJBI()
		{
		}
	}

	[Token(Token = "0x20005EB")]
	public enum GIABEFEBIDB
	{
		[Token(Token = "0x40044A0")]
		SYNC,
		[Token(Token = "0x40044A1")]
		SYNCLIST,
		[Token(Token = "0x40044A2")]
		GET_IN,
		[Token(Token = "0x40044A3")]
		GET_OUT,
		[Token(Token = "0x40044A4")]
		FIRE
	}

	[Token(Token = "0x4004486")]
	[FieldOffset(Offset = "0x78")]
	private IHAAMHPPLMG KFMGKCJMCAM;

	[Token(Token = "0x4004487")]
	[FieldOffset(Offset = "0x90")]
	public uint CannonID;

	[Token(Token = "0x4004488")]
	[FieldOffset(Offset = "0x94")]
	public Transform PivotTransform;

	[Token(Token = "0x4004489")]
	[FieldOffset(Offset = "0x98")]
	public Transform InCannonPosition;

	[Token(Token = "0x400448A")]
	[FieldOffset(Offset = "0x9C")]
	public Transform OutCannonPosition;

	[Token(Token = "0x400448B")]
	[FieldOffset(Offset = "0xA0")]
	public Vector3 originalForward;

	[Token(Token = "0x400448C")]
	[FieldOffset(Offset = "0xAC")]
	public Transform HorizontalRotRoot;

	[Token(Token = "0x400448D")]
	[FieldOffset(Offset = "0xB0")]
	public Transform VerticalRotRoot;

	[Token(Token = "0x400448E")]
	[FieldOffset(Offset = "0xB4")]
	public Transform CannonRoot;

	[Token(Token = "0x400448F")]
	[FieldOffset(Offset = "0xB8")]
	private Collider ABLAOAPPBGF;

	[Token(Token = "0x4004490")]
	[FieldOffset(Offset = "0xBC")]
	private GameObject ADHKNFNFDJI;

	[Token(Token = "0x4004491")]
	[FieldOffset(Offset = "0xC0")]
	private GameObject NHMFCHDKNDF;

	[Token(Token = "0x4004492")]
	[FieldOffset(Offset = "0xC4")]
	private GameObject BLOPMKOBFCC;

	[Token(Token = "0x4004493")]
	[FieldOffset(Offset = "0xC8")]
	private GameObject OOHGOCDLADH;

	[Token(Token = "0x4004494")]
	[FieldOffset(Offset = "0xCC")]
	private uint INLCOOIGKHF;

	[Token(Token = "0x4004495")]
	[FieldOffset(Offset = "0xD0")]
	private JIOPDEEJBFH BOPLAOANKBI;

	[Token(Token = "0x4004496")]
	[FieldOffset(Offset = "0xD4")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x4004497")]
	[FieldOffset(Offset = "0xD8")]
	private CEKDKEDHJBI PLGAAJABBHA;

	[Token(Token = "0x4004498")]
	[FieldOffset(Offset = "0xDC")]
	private Vector3 AEOBLCHJOJB;

	[Token(Token = "0x4004499")]
	[FieldOffset(Offset = "0xE8")]
	private Quaternion JOHDIIAGLOK;

	[Token(Token = "0x400449A")]
	[FieldOffset(Offset = "0xF8")]
	public float RotHorizontalRangeMinAngle;

	[Token(Token = "0x400449B")]
	[FieldOffset(Offset = "0xFC")]
	public float RotHorizontalRangeMaxAngle;

	[Token(Token = "0x400449C")]
	[FieldOffset(Offset = "0x100")]
	public float OriginalForwardAngle;

	[Token(Token = "0x170002E3")]
	public Vector3 BIKKBPJPALB
	{
		[Token(Token = "0x60023DD")]
		[Address(RVA = "0x23786D0", Offset = "0x23786D0", VA = "0x23786D0")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x60023DE")]
		[Address(RVA = "0x2378740", Offset = "0x2378740", VA = "0x2378740")]
		set
		{
		}
	}

	[Token(Token = "0x170002E4")]
	public Quaternion PIOIOHIDAGE
	{
		[Token(Token = "0x60023DF")]
		[Address(RVA = "0x2378A64", Offset = "0x2378A64", VA = "0x2378A64")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Quaternion);
		}
		[Token(Token = "0x60023E0")]
		[Address(RVA = "0x2378AD0", Offset = "0x2378AD0", VA = "0x2378AD0")]
		set
		{
		}
	}

	[Token(Token = "0x60023DB")]
	[Address(RVA = "0x23784E4", Offset = "0x23784E4", VA = "0x23784E4")]
	public LevelCannon()
	{
	}

	[Token(Token = "0x60023DC")]
	[Address(RVA = "0x237865C", Offset = "0x237865C", VA = "0x237865C")]
	public IHAAMHPPLMG PIDInCannon()
	{
		return default(IHAAMHPPLMG);
	}

	[Token(Token = "0x60023E1")]
	[Address(RVA = "0x23788A4", Offset = "0x23788A4", VA = "0x23788A4")]
	private void MBPOEOHPJHN()
	{
	}

	[Token(Token = "0x60023E2")]
	[Address(RVA = "0x2379114", Offset = "0x2379114", VA = "0x2379114", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60023E3")]
	[Address(RVA = "0x2379870", Offset = "0x2379870", VA = "0x2379870")]
	public uint GetAmmoID()
	{
		return default(uint);
	}

	[Token(Token = "0x60023E4")]
	[Address(RVA = "0x23798DC", Offset = "0x23798DC", VA = "0x23798DC", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x60023E5")]
	[Address(RVA = "0x2379628", Offset = "0x2379628", VA = "0x2379628")]
	public void CalculateHorizontalRotationRange()
	{
	}

	[Token(Token = "0x60023E6")]
	[Address(RVA = "0x2379A34", Offset = "0x2379A34", VA = "0x2379A34")]
	public void PushSyncState(Quaternion KHGMEBFPGKA, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x60023E7")]
	[Address(RVA = "0x2379B64", Offset = "0x2379B64", VA = "0x2379B64", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60023E8")]
	[Address(RVA = "0x2379FD8", Offset = "0x2379FD8", VA = "0x2379FD8", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x60023E9")]
	[Address(RVA = "0x237A07C", Offset = "0x237A07C", VA = "0x237A07C", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60023EA")]
	[Address(RVA = "0x237A490", Offset = "0x237A490", VA = "0x237A490")]
	private bool PJAHHOFEHKL(Player PJOIFFLCDPM)
	{
		return default(bool);
	}

	[Token(Token = "0x60023EB")]
	[Address(RVA = "0x237A5BC", Offset = "0x237A5BC", VA = "0x237A5BC")]
	private void HBJKIPNKBAK(Player PJOIFFLCDPM, bool KIEHGMEKBHI)
	{
	}

	[Token(Token = "0x60023EC")]
	[Address(RVA = "0x237AA40", Offset = "0x237AA40", VA = "0x237AA40", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x60023ED")]
	[Address(RVA = "0x237B51C", Offset = "0x237B51C", VA = "0x237B51C")]
	public void OnCannonFire()
	{
	}

	[Token(Token = "0x60023EE")]
	[Address(RVA = "0x237C834", Offset = "0x237C834", VA = "0x237C834")]
	private void BMOKANNMAAO()
	{
	}

	[Token(Token = "0x60023EF")]
	[Address(RVA = "0x2378D7C", Offset = "0x2378D7C", VA = "0x2378D7C")]
	private void DKPILNMGLMO()
	{
	}

	[Token(Token = "0x60023F0")]
	[Address(RVA = "0x2378FD0", Offset = "0x2378FD0", VA = "0x2378FD0")]
	private void DPOHFKOHKHP()
	{
	}

	[Token(Token = "0x60023F1")]
	[Address(RVA = "0x237A8F4", Offset = "0x237A8F4", VA = "0x237A8F4")]
	private void EBOAAJKKFFJ()
	{
	}

	[Token(Token = "0x60023F2")]
	[Address(RVA = "0x237CB10", Offset = "0x237CB10", VA = "0x237CB10", Slot = "23")]
	protected override void OnUpdateVisibleStateByStreamer(Vector3 MKGCDPNKMOB, Vector3 OANAHFHPBNB)
	{
	}

	[Token(Token = "0x60023F3")]
	[Address(RVA = "0x237CC94", Offset = "0x237CC94", VA = "0x237CC94")]
	private void GDICILBGKIJ()
	{
	}

	[Token(Token = "0x60023F4")]
	[Address(RVA = "0x2379948", Offset = "0x2379948", VA = "0x2379948")]
	private void GGBACBIFDCN()
	{
	}

	[Token(Token = "0x60023F5")]
	[Address(RVA = "0x237CFD4", Offset = "0x237CFD4", VA = "0x237CFD4")]
	private void HHIFPCFILBP(GameObject ECINOMEHBKA)
	{
	}

	[Token(Token = "0x60023F6")]
	[Address(RVA = "0x237C8F8", Offset = "0x237C8F8", VA = "0x237C8F8")]
	private void MPBNCEODAED(ResourceID FCMOICILFBP, GameObject ECINOMEHBKA)
	{
	}

	[Token(Token = "0x60023F7")]
	[Address(RVA = "0x237BC44", Offset = "0x237BC44", VA = "0x237BC44")]
	private void ANHALPGBLLI(CLFBGACHJJP AJKBOONEOAB, Vector3 CECACOBDFEP)
	{
	}

	[Token(Token = "0x60023F8")]
	[Address(RVA = "0x237BE4C", Offset = "0x237BE4C", VA = "0x237BE4C")]
	private void OKIMHPGJFAL(CLFBGACHJJP NMJPFHGBFGC, Vector3 CECACOBDFEP)
	{
	}

	[Token(Token = "0x60023F9")]
	[Address(RVA = "0x237D218", Offset = "0x237D218", VA = "0x237D218", Slot = "26")]
	protected override int GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x60023FA")]
	[Address(RVA = "0x237D270", Offset = "0x237D270", VA = "0x237D270", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x60023FB")]
	[Address(RVA = "0x237B9FC", Offset = "0x237B9FC", VA = "0x237B9FC")]
	public int GetCurrentHeat()
	{
		return default(int);
	}

	[Token(Token = "0x60023FC")]
	[Address(RVA = "0x237BB20", Offset = "0x237BB20", VA = "0x237BB20")]
	private bool MDIBHBJJCIJ()
	{
		return default(bool);
	}

	[Token(Token = "0x60023FD")]
	[Address(RVA = "0x237D454", Offset = "0x237D454", VA = "0x237D454")]
	public JIOPDEEJBFH GetData()
	{
		return null;
	}

	[Token(Token = "0x60023FE")]
	[Address(RVA = "0x237D4AC", Offset = "0x237D4AC", VA = "0x237D4AC")]
	public int GetShotCount()
	{
		return default(int);
	}

	[Token(Token = "0x60023FF")]
	[Address(RVA = "0x237D55C", Offset = "0x237D55C", VA = "0x237D55C")]
	public int GetTotalShotCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002400")]
	[Address(RVA = "0x237D5E4", Offset = "0x237D5E4", VA = "0x237D5E4")]
	private bool HGFEPADDDOG(JIOPDEEJBFH NHJNFPKBBLI)
	{
		return default(bool);
	}

	[Token(Token = "0x6002401")]
	[Address(RVA = "0x237D61C", Offset = "0x237D61C", VA = "0x237D61C")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x6002402")]
	[Address(RVA = "0x237D624", Offset = "0x237D624", VA = "0x237D624")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x6002403")]
	[Address(RVA = "0x237D62C", Offset = "0x237D62C", VA = "0x237D62C")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6002404")]
	[Address(RVA = "0x237D634", Offset = "0x237D634", VA = "0x237D634")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	[Token(Token = "0x6002405")]
	[Address(RVA = "0x237D63C", Offset = "0x237D63C", VA = "0x237D63C")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	[Token(Token = "0x6002406")]
	[Address(RVA = "0x237D644", Offset = "0x237D644", VA = "0x237D644")]
	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	[Token(Token = "0x6002407")]
	[Address(RVA = "0x237D678", Offset = "0x237D678", VA = "0x237D678")]
	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return default(int);
	}

	[Token(Token = "0x6002408")]
	[Address(RVA = "0x237D680", Offset = "0x237D680", VA = "0x237D680")]
	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}
}
