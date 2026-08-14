using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200043D")]
public class GrenadeLine : MonoBehaviour
{
	[Token(Token = "0x4003C13")]
	[FieldOffset(Offset = "0xC")]
	protected bool m_ShowGrenadeLine;

	[Token(Token = "0x4003C14")]
	[FieldOffset(Offset = "0x10")]
	protected LineRenderer m_GrenadeLine;

	[Token(Token = "0x4003C15")]
	[FieldOffset(Offset = "0x14")]
	private float interval;

	[Token(Token = "0x4003C16")]
	private const int pos_count = 75;

	[Token(Token = "0x4003C17")]
	private const float grenadeLauncher1stPosRatio = 0.15f;

	[Token(Token = "0x170001D9")]
	protected bool ShowGrenadeLine
	{
		[Token(Token = "0x6001527")]
		[Address(RVA = "0x120DB94", Offset = "0x120DB94", VA = "0x120DB94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6001528")]
		[Address(RVA = "0x120DBEC", Offset = "0x120DBEC", VA = "0x120DBEC")]
		set
		{
		}
	}

	[Token(Token = "0x6001526")]
	[Address(RVA = "0x120DB80", Offset = "0x120DB80", VA = "0x120DB80")]
	public GrenadeLine()
	{
	}

	[Token(Token = "0x6001529")]
	[Address(RVA = "0x120DC6C", Offset = "0x120DC6C", VA = "0x120DC6C")]
	private void OnShowGrenadeLineChanged()
	{
	}

	[Token(Token = "0x600152A")]
	[Address(RVA = "0x120DD8C", Offset = "0x120DD8C", VA = "0x120DD8C")]
	private void Start()
	{
	}

	[Token(Token = "0x600152B")]
	[Address(RVA = "0x120DF48", Offset = "0x120DF48", VA = "0x120DF48")]
	private void Destroy()
	{
	}

	[Token(Token = "0x600152C")]
	[Address(RVA = "0x120E0D8", Offset = "0x120E0D8", VA = "0x120E0D8")]
	private void Update()
	{
	}

	[Token(Token = "0x600152D")]
	[Address(RVA = "0x120E6AC", Offset = "0x120E6AC", VA = "0x120E6AC")]
	private void DrawLine(Vector3 throwPos, Vector3 throwVel, Vector3 gravity)
	{
	}

	[Token(Token = "0x600152E")]
	[Address(RVA = "0x120E8F4", Offset = "0x120E8F4", VA = "0x120E8F4")]
	private void DrawLine2(Vector3 throwPos, Vector3 throwVel, Vector3 gravity)
	{
	}

	[Token(Token = "0x600152F")]
	[Address(RVA = "0x120ED90", Offset = "0x120ED90", VA = "0x120ED90", Slot = "4")]
	protected virtual void OnGrenadeCrosshairFireChange(object[] data)
	{
	}
}
