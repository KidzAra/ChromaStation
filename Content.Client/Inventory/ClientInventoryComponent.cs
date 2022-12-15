using Content.Shared.Inventory;

namespace Content.Client.Inventory
{
    /// <summary>
    /// A character UI which shows items the user has equipped within his inventory
    /// </summary>
    [RegisterComponent]
    [ComponentReference(typeof(InventoryComponent))]
    [Access(typeof(ClientInventorySystem))]
    public sealed class ClientInventoryComponent : InventoryComponent
    {
        [DataField("speciesId")]
        public string? SpeciesId { get; set; }

        [ViewVariables]
        [Access(typeof(ClientInventorySystem), Other = AccessPermissions.ReadWriteExecute)] // FIXME Friends
        public readonly Dictionary<string, ClientInventorySystem.SlotData> SlotData = new ();

        /// <summary>
        ///     Data about the current layers that have been added to the players sprite due to the items in each equipment slot.
        /// </summary>
        [ViewVariables]
        [Access(typeof(ClientInventorySystem), Other = AccessPermissions.ReadWriteExecute)] // FIXME Friends
        public readonly Dictionary<string, HashSet<string>> VisualLayerKeys = new();
    }
}
