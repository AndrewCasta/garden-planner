import create from 'zustand';

export interface AppState {
  crop: { id: number; name: string };
  setCrop: (crop: { id: number; name: string }) => void;
}

export const useStore = create<AppState>()(set => ({
  crop: { id: 0, name: 'No crop selected' },
  setCrop: crop => set(state => ({ crop: crop })),
}));
