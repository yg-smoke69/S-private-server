using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20003D9")]
internal abstract class NetworkAIPawnAnimBaseComponent : MonoBehaviour
{
	[Token(Token = "0x400393B")]
	[FieldOffset(Offset = "0xC")]
	protected NetworkAIPawn KKCJENLJDCP;

	[Token(Token = "0x400393C")]
	[FieldOffset(Offset = "0x10")]
	public bool SkipDeathAnim;

	[Token(Token = "0x400393D")]
	[FieldOffset(Offset = "0x14")]
	protected float LFFLPMLNLCF;

	[Token(Token = "0x400393E")]
	[FieldOffset(Offset = "0x18")]
	protected float MOPABKDNIBB;

	[Token(Token = "0x1700019E")]
	public virtual Animation GMLJAEMAFNO
	{
		[Token(Token = "0x600113C")]
		[Address(RVA = "0x17E8A44", Offset = "0x17E8A44", VA = "0x17E8A44", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700019F")]
	public virtual Animator GBGNONFPAOF
	{
		[Token(Token = "0x600113D")]
		[Address(RVA = "0x17E8A9C", Offset = "0x17E8A9C", VA = "0x17E8A9C", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600113A")]
	[Address(RVA = "0x17E8A2C", Offset = "0x17E8A2C", VA = "0x17E8A2C")]
	protected NetworkAIPawnAnimBaseComponent()
	{
	}

	[Token(Token = "0x600113B")]
	public abstract void Init(NetworkAIPawn FIMNKGABILM, [Optional] Animation CFGGELHHJLD, [Optional] Animator HLIOOJLOAGA);

	[Token(Token = "0x600113E")]
	[Address(RVA = "0x17E8AF4", Offset = "0x17E8AF4", VA = "0x17E8AF4", Slot = "7")]
	public virtual void PlayAttack()
	{
	}

	[Token(Token = "0x600113F")]
	[Address(RVA = "0x17E8B48", Offset = "0x17E8B48", VA = "0x17E8B48", Slot = "8")]
	public virtual void PlayHitfly()
	{
	}

	[Token(Token = "0x6001140")]
	[Address(RVA = "0x17E8B9C", Offset = "0x17E8B9C", VA = "0x17E8B9C", Slot = "9")]
	public virtual void StopHitfly(bool BAJJBNNNGIH)
	{
	}

	[Token(Token = "0x6001141")]
	public abstract void Dead(bool KCHNLMEEHOP, bool FDICOIFLBAD);

	[Token(Token = "0x6001142")]
	public abstract void SetSpeed(float OJGNBJELDEM);

	[Token(Token = "0x6001143")]
	[Address(RVA = "0x17E8BF8", Offset = "0x17E8BF8", VA = "0x17E8BF8")]
	protected void FDBCECMAOGD()
	{
	}

	[Token(Token = "0x6001144")]
	public abstract bool PlaySkillAnim(OPKPPFDNCMC GEPIPPKAIBK, GDEHAFJBPGE LGIMFPCBALH, float GGMFDABGEKN, float NCGNOHEHDML, bool ICLFBLKGENK);

	[Token(Token = "0x6001145")]
	[Address(RVA = "0x17E8DC0", Offset = "0x17E8DC0", VA = "0x17E8DC0", Slot = "13")]
	public virtual bool UpdateSkillAnim(OPKPPFDNCMC GEPIPPKAIBK, GDEHAFJBPGE LGIMFPCBALH, int HBGPBPOMLDG, float MIEOJFFIIHH)
	{
		return default(bool);
	}

	[Token(Token = "0x6001146")]
	[Address(RVA = "0x17E8E50", Offset = "0x17E8E50", VA = "0x17E8E50", Slot = "14")]
	public virtual void UpdateAnimSpeed(float PHEJDNJONIL)
	{
	}
}
