using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000433")]
internal class SkydivingCamera : CameraControllerBase
{
	[Token(Token = "0x4003BB2")]
	[FieldOffset(Offset = "0x24")]
	public float UpOffset;

	[Token(Token = "0x4003BB3")]
	[FieldOffset(Offset = "0x28")]
	public float BackOffset;

	[Token(Token = "0x4003BB4")]
	[FieldOffset(Offset = "0x2C")]
	public float FOV;

	[Token(Token = "0x4003BB5")]
	[FieldOffset(Offset = "0x30")]
	public float TransSpeed;

	[Token(Token = "0x4003BB6")]
	[FieldOffset(Offset = "0x34")]
	public float m_TransitionStartUpOffset;

	[Token(Token = "0x4003BB7")]
	[FieldOffset(Offset = "0x38")]
	public float m_TransitionStartBackOffset;

	[Token(Token = "0x4003BB8")]
	[FieldOffset(Offset = "0x3C")]
	public float m_CurrentUpOffset;

	[Token(Token = "0x4003BB9")]
	[FieldOffset(Offset = "0x40")]
	public float m_CurrentBackOffset;

	[Token(Token = "0x4003BBA")]
	[FieldOffset(Offset = "0x44")]
	public float m_CurrentFOV;

	[Token(Token = "0x4003BBB")]
	[FieldOffset(Offset = "0x48")]
	private ParachuteParam IDOFIKBBFPJ;

	[Token(Token = "0x4003BBC")]
	[FieldOffset(Offset = "0x4C")]
	private ParachuteStateParameter MGNDLANDFFO;

	[Token(Token = "0x4003BBD")]
	[FieldOffset(Offset = "0x50")]
	private float HMBJNNIEICI;

	[Token(Token = "0x4003BBE")]
	[FieldOffset(Offset = "0x54")]
	private float PBPLBBNODKB;

	[Token(Token = "0x4003BBF")]
	[FieldOffset(Offset = "0x58")]
	private float PCOIOLKGGHL;

	[Token(Token = "0x4003BC0")]
	[FieldOffset(Offset = "0x5C")]
	private float HNCIHCGAMHC;

	[Token(Token = "0x170001D0")]
	protected Player GEMHAAHJBBD
	{
		[Token(Token = "0x60014D8")]
		[Address(RVA = "0x1D7AA70", Offset = "0x1D7AA70", VA = "0x1D7AA70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60014D7")]
	[Address(RVA = "0x1D7AA4C", Offset = "0x1D7AA4C", VA = "0x1D7AA4C")]
	public SkydivingCamera()
	{
	}

	[Token(Token = "0x60014D9")]
	[Address(RVA = "0x1D7AC20", Offset = "0x1D7AC20", VA = "0x1D7AC20")]
	private void Awake()
	{
	}

	[Token(Token = "0x60014DA")]
	[Address(RVA = "0x1D7ADE0", Offset = "0x1D7ADE0", VA = "0x1D7ADE0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x60014DB")]
	[Address(RVA = "0x1D7AF08", Offset = "0x1D7AF08", VA = "0x1D7AF08", Slot = "6")]
	public override void OnCameraChanged()
	{
	}

	[Token(Token = "0x60014DC")]
	[Address(RVA = "0x1D7AF9C", Offset = "0x1D7AF9C", VA = "0x1D7AF9C")]
	public void SetOffset(CPJPELKILMM GLDLCOBLGNF = CPJPELKILMM.None)
	{
	}

	[Token(Token = "0x60014DD")]
	[Address(RVA = "0x1D7B3D8", Offset = "0x1D7B3D8", VA = "0x1D7B3D8")]
	public void SetOffset(float CNACGBKBBIJ, float DDDLBAHBIEG, bool MKLKBFHMNBD)
	{
	}

	[Token(Token = "0x60014DE")]
	[Address(RVA = "0x1D7B4C4", Offset = "0x1D7B4C4", VA = "0x1D7B4C4")]
	protected void GAPPNBOBABL()
	{
	}

	[Token(Token = "0x60014DF")]
	[Address(RVA = "0x1D7B7D8", Offset = "0x1D7B7D8", VA = "0x1D7B7D8")]
	private void NEDPPICIOPO()
	{
	}

	[Token(Token = "0x60014E0")]
	[Address(RVA = "0x1D7BA28", Offset = "0x1D7BA28", VA = "0x1D7BA28")]
	private void EOOFODDDLAF(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x60014E1")]
	[Address(RVA = "0x1D7C120", Offset = "0x1D7C120", VA = "0x1D7C120", Slot = "4")]
	protected override void IMEHMEOBENM()
	{
	}

	[Token(Token = "0x60014E2")]
	[Address(RVA = "0x1D7BFD0", Offset = "0x1D7BFD0", VA = "0x1D7BFD0")]
	private Transform KOLPJBDFMDJ()
	{
		return null;
	}

	[Token(Token = "0x60014E3")]
	[Address(RVA = "0x1D7C630", Offset = "0x1D7C630", VA = "0x1D7C630")]
	public void _003C_003EiFixBaseProxy_OnCameraChanged()
	{
	}

	[Token(Token = "0x60014E4")]
	[Address(RVA = "0x1D7C638", Offset = "0x1D7C638", VA = "0x1D7C638")]
	public void _003C_003EiFixBaseProxy_IMEHMEOBENM()
	{
	}
}
