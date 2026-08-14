using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20005D8")]
internal class LevelAutoFlightBomb : BaseLevelObject
{
	[Token(Token = "0x20005D9")]
	protected class HHCBNAPCKHF : ShadowStateBase
	{
		[Token(Token = "0x4004432")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 JHJLNLCEGOG;

		[Token(Token = "0x4004433")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x6002358")]
		[Address(RVA = "0x17D6588", Offset = "0x17D6588", VA = "0x17D6588")]
		public HHCBNAPCKHF()
		{
		}
	}

	[Token(Token = "0x20005DA")]
	private sealed class GIODLDFJAHJ : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4004434")]
		[FieldOffset(Offset = "0x8")]
		internal LevelAutoFlightBomb GADHAMJEKIM;

		[Token(Token = "0x4004435")]
		[FieldOffset(Offset = "0xC")]
		internal object IGDGEPMDDKK;

		[Token(Token = "0x4004436")]
		[FieldOffset(Offset = "0x10")]
		internal bool KGJPAECOOLN;

		[Token(Token = "0x4004437")]
		[FieldOffset(Offset = "0x14")]
		internal int EKHKDHNLJJH;

		[Token(Token = "0x170002E1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600235B")]
			[Address(RVA = "0x17D9C8C", Offset = "0x17D9C8C", VA = "0x17D9C8C", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002E2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600235C")]
			[Address(RVA = "0x17D9C94", Offset = "0x17D9C94", VA = "0x17D9C94", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002359")]
		[Address(RVA = "0x17D8824", Offset = "0x17D8824", VA = "0x17D8824")]
		public GIODLDFJAHJ()
		{
		}

		[Token(Token = "0x600235A")]
		[Address(RVA = "0x17D9BE0", Offset = "0x17D9BE0", VA = "0x17D9BE0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600235D")]
		[Address(RVA = "0x17D9C9C", Offset = "0x17D9C9C", VA = "0x17D9C9C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600235E")]
		[Address(RVA = "0x17D9CB0", Offset = "0x17D9CB0", VA = "0x17D9CB0", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4004420")]
	[FieldOffset(Offset = "0x74")]
	public Animator m_Animator;

	[Token(Token = "0x4004421")]
	[FieldOffset(Offset = "0x78")]
	public GameObject m_RenderRoot;

	[Token(Token = "0x4004422")]
	[FieldOffset(Offset = "0x7C")]
	public SkinnedMeshRenderer m_FlightRender;

	[Token(Token = "0x4004423")]
	[FieldOffset(Offset = "0x80")]
	public GameObject YellowVfx;

	[Token(Token = "0x4004424")]
	[FieldOffset(Offset = "0x84")]
	public GameObject RedVfx;

	[Token(Token = "0x4004425")]
	[FieldOffset(Offset = "0x88")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x4004426")]
	[FieldOffset(Offset = "0x8C")]
	protected HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x4004427")]
	[FieldOffset(Offset = "0x90")]
	private float OIDKBLJJGFF;

	[Token(Token = "0x4004428")]
	[FieldOffset(Offset = "0x98")]
	private IHAAMHPPLMG IFNKBBHCLFN;

	[Token(Token = "0x4004429")]
	[FieldOffset(Offset = "0xB0")]
	private IHAAMHPPLMG KIAOOKECPLC;

	[Token(Token = "0x400442A")]
	[FieldOffset(Offset = "0xC8")]
	private IKKCIBAIDIN EGOBBHJJAFL;

	[Token(Token = "0x400442B")]
	[FieldOffset(Offset = "0xCC")]
	private GameObject HHACCGLJDOL;

	[Token(Token = "0x400442C")]
	[FieldOffset(Offset = "0xD0")]
	private ResourceID JKILFKNGIFJ;

	[Token(Token = "0x400442D")]
	[FieldOffset(Offset = "0xD4")]
	private float IBKBAEDLFNE;

	[Token(Token = "0x400442E")]
	[FieldOffset(Offset = "0xD8")]
	private float ONPOCEDIDBJ;

	[Token(Token = "0x400442F")]
	[FieldOffset(Offset = "0xDC")]
	private bool MHEJFBGBLJG;

	[Token(Token = "0x4004430")]
	[FieldOffset(Offset = "0xE0")]
	private MADMMIICBNN KFOBDIGCMEO;

	[Token(Token = "0x4004431")]
	[FieldOffset(Offset = "0xE4")]
	private uint CBCJPKAEBHE;

	[Token(Token = "0x6002341")]
	[Address(RVA = "0x17D64B4", Offset = "0x17D64B4", VA = "0x17D64B4")]
	public LevelAutoFlightBomb()
	{
	}

	[Token(Token = "0x6002342")]
	[Address(RVA = "0x17D6590", Offset = "0x17D6590", VA = "0x17D6590")]
	private void GCOLKFOFBBE()
	{
	}

	[Token(Token = "0x6002343")]
	[Address(RVA = "0x17D6864", Offset = "0x17D6864", VA = "0x17D6864", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002344")]
	[Address(RVA = "0x17D6A50", Offset = "0x17D6A50", VA = "0x17D6A50")]
	public void InitParms(float LCMKCHOILIB, IHAAMHPPLMG MHAAKMGCDHH, IHAAMHPPLMG PIJKECGJDBD, IKKCIBAIDIN GLDLCOBLGNF, float EAIENJKPFCG, float KAHANFFHOMG)
	{
	}

	[Token(Token = "0x6002345")]
	[Address(RVA = "0x17D73F0", Offset = "0x17D73F0", VA = "0x17D73F0")]
	private IEnumerator BBMNLBKNMEH()
	{
		return null;
	}

	[Token(Token = "0x6002346")]
	[Address(RVA = "0x17D882C", Offset = "0x17D882C", VA = "0x17D882C")]
	private Vector3 LMFHBOFDIBO(Player PJOIFFLCDPM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002347")]
	[Address(RVA = "0x17D8998", Offset = "0x17D8998", VA = "0x17D8998")]
	private bool CKGPCLFNNLJ(Player PJOIFFLCDPM)
	{
		return default(bool);
	}

	[Token(Token = "0x6002348")]
	[Address(RVA = "0x17D765C", Offset = "0x17D765C", VA = "0x17D765C")]
	private void JECFFCPGBEN()
	{
	}

	[Token(Token = "0x6002349")]
	[Address(RVA = "0x17D74BC", Offset = "0x17D74BC", VA = "0x17D74BC")]
	private void NNGAMEFMAOC(IKKCIBAIDIN GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x600234A")]
	[Address(RVA = "0x17D81A8", Offset = "0x17D81A8", VA = "0x17D81A8")]
	private Quaternion OALBCBPNMFA()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x600234B")]
	[Address(RVA = "0x17D8A94", Offset = "0x17D8A94", VA = "0x17D8A94", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600234C")]
	[Address(RVA = "0x17D8DF0", Offset = "0x17D8DF0", VA = "0x17D8DF0")]
	public void PushState(IKKCIBAIDIN GLDLCOBLGNF, Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x600234D")]
	[Address(RVA = "0x17D9464", Offset = "0x17D9464", VA = "0x17D9464")]
	public void DelayDestroy()
	{
	}

	[Token(Token = "0x600234E")]
	protected T MAONFJNPNHJ<T>(ResourceID IDNEFEOPGIF) where T : class
	{
		return null;
	}

	[Token(Token = "0x600234F")]
	[Address(RVA = "0x17D9678", Offset = "0x17D9678", VA = "0x17D9678")]
	private void IDGONNNLJCA(ResourceID IDNEFEOPGIF, Transform ACICLMFFFOA)
	{
	}

	[Token(Token = "0x6002350")]
	[Address(RVA = "0x17D8678", Offset = "0x17D8678", VA = "0x17D8678")]
	public void Destroy()
	{
	}

	[Token(Token = "0x6002351")]
	[Address(RVA = "0x17D9988", Offset = "0x17D9988", VA = "0x17D9988")]
	public void PusMoveState(Vector3 MLCIHBOHEHE, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6002352")]
	[Address(RVA = "0x17D9ABC", Offset = "0x17D9ABC", VA = "0x17D9ABC", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x6002353")]
	[Address(RVA = "0x17D9B20", Offset = "0x17D9B20", VA = "0x17D9B20", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002354")]
	[Address(RVA = "0x17D9BC4", Offset = "0x17D9BC4", VA = "0x17D9BC4")]
	private void JDHGBMFINCG()
	{
	}

	[Token(Token = "0x6002355")]
	[Address(RVA = "0x17D9BC8", Offset = "0x17D9BC8", VA = "0x17D9BC8")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x6002356")]
	[Address(RVA = "0x17D9BD0", Offset = "0x17D9BD0", VA = "0x17D9BD0")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6002357")]
	[Address(RVA = "0x17D9BD8", Offset = "0x17D9BD8", VA = "0x17D9BD8")]
	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}
}
