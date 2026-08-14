using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200062F")]
internal class LevelGrapplingHook : BaseLevelObject
{
	[Token(Token = "0x2000630")]
	private enum JEDGKELACNL
	{
		[Token(Token = "0x4004654")]
		FLYING,
		[Token(Token = "0x4004655")]
		HOOKED,
		[Token(Token = "0x4004656")]
		DESTROY
	}

	[Token(Token = "0x4004640")]
	[FieldOffset(Offset = "0x74")]
	public Transform LineSocket;

	[Token(Token = "0x4004641")]
	[FieldOffset(Offset = "0x78")]
	public LineRenderer Line;

	[Token(Token = "0x4004642")]
	[FieldOffset(Offset = "0x7C")]
	private CLFBGACHJJP APAFCNEACMB;

	[Token(Token = "0x4004643")]
	[FieldOffset(Offset = "0x80")]
	private FKPFNILEOHE EFGDILOKKDP;

	[Token(Token = "0x4004644")]
	[FieldOffset(Offset = "0x180")]
	private IHAAMHPPLMG BMMEPIFKKHM;

	[Token(Token = "0x4004645")]
	[FieldOffset(Offset = "0x198")]
	private Vector3 JDGGPDAGBEM;

	[Token(Token = "0x4004646")]
	[FieldOffset(Offset = "0x1A4")]
	private Vector3 LIDAEDNKINL;

	[Token(Token = "0x4004647")]
	[FieldOffset(Offset = "0x1B0")]
	private Vector3 BFFAGIFANAD;

	[Token(Token = "0x4004648")]
	[FieldOffset(Offset = "0x1BC")]
	private bool HPFKOAFPKGG;

	[Token(Token = "0x4004649")]
	[FieldOffset(Offset = "0x1C0")]
	private Vector3 GNALNJFIFAD;

	[Token(Token = "0x400464A")]
	[FieldOffset(Offset = "0x1CC")]
	private ResourceID OMPLENJKELJ;

	[Token(Token = "0x400464B")]
	[FieldOffset(Offset = "0x1D0")]
	private MADMMIICBNN HDFMCJHLJAD;

	[Token(Token = "0x400464C")]
	[FieldOffset(Offset = "0x1D4")]
	private bool BKJFIFGFMCC;

	[Token(Token = "0x400464D")]
	[FieldOffset(Offset = "0x1D8")]
	private JEDGKELACNL LMJPMODNADG;

	[Token(Token = "0x400464E")]
	[FieldOffset(Offset = "0x1DC")]
	private float CJBADPOGBOL;

	[Token(Token = "0x400464F")]
	[FieldOffset(Offset = "0x1E0")]
	private float DEOIONFIDNH;

	[Token(Token = "0x4004650")]
	[FieldOffset(Offset = "0x1E4")]
	private bool CMMJBEKIECF;

	[Token(Token = "0x4004651")]
	[FieldOffset(Offset = "0x1E8")]
	private Vector3 JOMLPLHBLCB;

	[Token(Token = "0x4004652")]
	[FieldOffset(Offset = "0x1F4")]
	private bool LOEOMDJBBNF;

	[Token(Token = "0x170002F7")]
	public CLFBGACHJJP NLJHMEBFDLE
	{
		[Token(Token = "0x600264B")]
		[Address(RVA = "0x27279F0", Offset = "0x27279F0", VA = "0x27279F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600264A")]
		[Address(RVA = "0x2727990", Offset = "0x2727990", VA = "0x2727990")]
		set
		{
		}
	}

	[Token(Token = "0x170002F8")]
	public FKPFNILEOHE DNNNAHEBGHE
	{
		[Token(Token = "0x600264D")]
		[Address(RVA = "0x2727B0C", Offset = "0x2727B0C", VA = "0x2727B0C")]
		get
		{
			return default(FKPFNILEOHE);
		}
		[Token(Token = "0x600264C")]
		[Address(RVA = "0x2727A48", Offset = "0x2727A48", VA = "0x2727A48")]
		set
		{
		}
	}

	[Token(Token = "0x170002F9")]
	public Vector3 JHJLNLCEGOG
	{
		[Token(Token = "0x600264F")]
		[Address(RVA = "0x2727C20", Offset = "0x2727C20", VA = "0x2727C20")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x170002FA")]
	public Vector3 CLDFALFMCED
	{
		[Token(Token = "0x6002650")]
		[Address(RVA = "0x2727C90", Offset = "0x2727C90", VA = "0x2727C90")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
	}

	[Token(Token = "0x170002FB")]
	public Vector3 FHCCOMAMHGO
	{
		[Token(Token = "0x6002651")]
		[Address(RVA = "0x2727D00", Offset = "0x2727D00", VA = "0x2727D00")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x6002652")]
		[Address(RVA = "0x2727D70", Offset = "0x2727D70", VA = "0x2727D70")]
		set
		{
		}
	}

	[Token(Token = "0x6002649")]
	[Address(RVA = "0x2727798", Offset = "0x2727798", VA = "0x2727798")]
	public LevelGrapplingHook()
	{
	}

	[Token(Token = "0x600264E")]
	[Address(RVA = "0x2727B7C", Offset = "0x2727B7C", VA = "0x2727B7C", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002653")]
	[Address(RVA = "0x2727DF8", Offset = "0x2727DF8", VA = "0x2727DF8")]
	private Vector3 COABPONMPJG()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002654")]
	[Address(RVA = "0x2727F14", Offset = "0x2727F14", VA = "0x2727F14")]
	private Player FGEKCPALMOA()
	{
		return null;
	}

	[Token(Token = "0x6002655")]
	[Address(RVA = "0x272810C", Offset = "0x272810C", VA = "0x272810C")]
	public Vector3 GetHookDir()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002656")]
	[Address(RVA = "0x2728214", Offset = "0x2728214", VA = "0x2728214")]
	private void Reset()
	{
	}

	[Token(Token = "0x6002657")]
	[Address(RVA = "0x27282EC", Offset = "0x27282EC", VA = "0x27282EC")]
	public void OnResSpawn(Player KAEHJEGFKBL, Vector3 BNDPJDJAFOM, Vector3 COCOBLKAIMJ, bool CLLEAKNKAHA, Vector3 DOBOBMFMKBJ, ResourceID FCMOICILFBP, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6002658")]
	[Address(RVA = "0x2728934", Offset = "0x2728934", VA = "0x2728934")]
	public void OnResHooked(Vector3 BGEFJGGHGNG)
	{
	}

	[Token(Token = "0x6002659")]
	[Address(RVA = "0x2728A9C", Offset = "0x2728A9C", VA = "0x2728A9C")]
	public void OnResDel(byte OMNGGLFFMGM)
	{
	}

	[Token(Token = "0x600265A")]
	[Address(RVA = "0x2728EB0", Offset = "0x2728EB0", VA = "0x2728EB0")]
	public void OnSyncForReEnter(Player KAEHJEGFKBL, Vector3 BNDPJDJAFOM, Vector3 OAJHDGMMJKM, Vector3 COCOBLKAIMJ, ResourceID FCMOICILFBP, uint BOEIBGAABDL, bool NCALNNGAOPC, Vector3 JEFDEODEDKJ, Vector3 JOPJJGMIHNN)
	{
	}

	[Token(Token = "0x600265B")]
	[Address(RVA = "0x2729550", Offset = "0x2729550", VA = "0x2729550")]
	public void OnOwnerDead()
	{
	}

	[Token(Token = "0x600265C")]
	[Address(RVA = "0x2728D00", Offset = "0x2728D00", VA = "0x2728D00")]
	private void GHEBMCHAHBM()
	{
	}

	[Token(Token = "0x600265D")]
	[Address(RVA = "0x27295B0", Offset = "0x27295B0", VA = "0x27295B0", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600265E")]
	[Address(RVA = "0x27293A0", Offset = "0x27293A0", VA = "0x27293A0")]
	private Vector3 MOFDFAIMOOB(Player PJOIFFLCDPM)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600265F")]
	[Address(RVA = "0x272A160", Offset = "0x272A160", VA = "0x272A160")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6002660")]
	[Address(RVA = "0x272A4BC", Offset = "0x272A4BC", VA = "0x272A4BC")]
	public void OnOwnerGetOff()
	{
	}

	[Token(Token = "0x6002661")]
	[Address(RVA = "0x272A534", Offset = "0x272A534", VA = "0x272A534")]
	public void HideLine()
	{
	}

	[Token(Token = "0x6002662")]
	[Address(RVA = "0x2729F68", Offset = "0x2729F68", VA = "0x2729F68")]
	private void NGEECAOILNN(byte OMNGGLFFMGM)
	{
	}

	[Token(Token = "0x6002663")]
	[Address(RVA = "0x272A660", Offset = "0x272A660", VA = "0x272A660")]
	public Vector3 FixedFinalPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002664")]
	[Address(RVA = "0x272A770", Offset = "0x272A770", VA = "0x272A770")]
	private float LFNNOHDALPC(float CODNOHMIJKK)
	{
		return default(float);
	}

	[Token(Token = "0x6002665")]
	[Address(RVA = "0x272A90C", Offset = "0x272A90C", VA = "0x272A90C")]
	public Vector3 CalcPlayerInitVelocity()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002666")]
	[Address(RVA = "0x272AF68", Offset = "0x272AF68", VA = "0x272AF68")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
