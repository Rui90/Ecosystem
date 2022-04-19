import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StorageCreationOverlayComponent } from './storage-creation-overlay.component';

describe('StorageCreationOverlayComponent', () => {
  let component: StorageCreationOverlayComponent;
  let fixture: ComponentFixture<StorageCreationOverlayComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ StorageCreationOverlayComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(StorageCreationOverlayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
