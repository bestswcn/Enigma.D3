public class AffixTable : MemoryObject
{
	// 2.0.5.24017
	public const int SizeOf = 0x10; // 16

	public AffixTable(ProcessMemory memory, int address)
		: base(memory, address) { }

	public SerializeData x00 { get { return Field<SerializeData>(0x00); } }
	public int x08_Count { get { return Field<int>(0x08); } }
	public AffixTableEntry[] x0C_PtrArray { get { return Dereference<AffixTableEntry>(0x0C, x08_Count); } }
}