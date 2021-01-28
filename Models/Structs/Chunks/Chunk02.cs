using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SRAM.SoE.Models.Structs.Chunks
{
	/// <summary>
	/// BoyCurrentHp
	/// </summary>
	/// <remarks><see cref="SramSizes.SaveSlot.Chunk02"/></remarks>
	[DebuggerDisplay("{ToString(),nq}")]
	[StructLayout(LayoutKind.Sequential, Pack = 2)]
	public struct Chunk02
	{
		public UInt16 BoyCurrentHp; // [110|x69] :: (2 bytes)

		public override string ToString() => BoyCurrentHp.ToString();
	}
}