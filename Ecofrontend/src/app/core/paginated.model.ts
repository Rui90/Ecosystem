export class Paginated<T> {
    public totalEntries: number;
    public entries: T[];

    construtor() {
        this.totalEntries = 0;
    }
  }
  