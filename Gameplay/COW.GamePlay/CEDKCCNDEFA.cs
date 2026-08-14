using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x20004FF")]
internal abstract class CEDKCCNDEFA<P, T, V> : _Attribute where T : AttackableEntity
{
	[Token(Token = "0x2000500")]
	private sealed class AONDOODHEKO
	{
		[Token(Token = "0x4004157")]
		[FieldOffset(Offset = "0x0")]
		internal T FFDHFKIMFDG;

		[Token(Token = "0x4004158")]
		[FieldOffset(Offset = "0x0")]
		internal Transform FBIFOOAGGHM;

		[Token(Token = "0x4004159")]
		[FieldOffset(Offset = "0x0")]
		internal COW.GamePlay.CEDKCCNDEFA<P, T, V> GADHAMJEKIM;

		[Token(Token = "0x6001A3A")]
		public AONDOODHEKO()
		{
		}

		[Token(Token = "0x6001A3B")]
		internal void CHOPCLCOBKC(T IBBLLLPJLGH)
		{
		}
	}

	[Token(Token = "0x4004154")]
	[FieldOffset(Offset = "0x0")]
	protected P BGOEEFONLKD;

	[Token(Token = "0x4004155")]
	[FieldOffset(Offset = "0x0")]
	protected V PMCNIIGEDCK;

	[Token(Token = "0x4004156")]
	[FieldOffset(Offset = "0x0")]
	protected COW.GamePlay.JPIHILACKHH<P, T> AEOFIFMLPAA;

	[Token(Token = "0x6001A35")]
	protected CEDKCCNDEFA()
	{
	}

	[Token(Token = "0x6001A36")]
	public virtual AttackableEntity MDDLBBBKHML(Transform FBIFOOAGGHM, AttackableEntity MLGKHMFMJHP)
	{
		return null;
	}

	[Token(Token = "0x6001A37")]
	protected AttackableEntity DLDOKEABDOC(Transform FBIFOOAGGHM, T FFDHFKIMFDG)
	{
		return null;
	}

	[Token(Token = "0x6001A38")]
	protected virtual bool LAPGLFOMLGL(T AAFBIANMEAL)
	{
		return default(bool);
	}

	[Token(Token = "0x6001A39")]
	protected abstract T CPCKCPLDIKI(Transform FBIFOOAGGHM, T AAFBIANMEAL, T KENDCFNPDCE, ref V DBGBPGFHKHE);
}
